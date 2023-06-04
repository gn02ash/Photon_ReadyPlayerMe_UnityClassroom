using UnityEngine;
using Photon.Pun;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class MeshSynchronizer : MonoBehaviourPun, IPunObservable
{
    private SkinnedMeshRenderer skinnedMeshRenderer;
    private byte[] serializedMeshData;
    private Material material;

    private void Start()
    {
        skinnedMeshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        material = skinnedMeshRenderer.sharedMaterial;
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // We own this player, send the mesh and material data to others
            if (skinnedMeshRenderer.sharedMesh != null)
            {
                serializedMeshData = SerializeMesh(skinnedMeshRenderer.sharedMesh);
                stream.SendNext(serializedMeshData.Length);
                stream.SendNext(serializedMeshData);
                Debug.Log("mesh meshed normalement");
            }
            else
            {
                stream.SendNext(0); // No mesh data to send
            }

            stream.SendNext(material);
        }
        else
        {
            // Network player, receive the mesh and material data
            int meshDataLength = (int)stream.ReceiveNext();
            if (meshDataLength > 0)
            {
                byte[] receivedMeshData = (byte[])stream.ReceiveNext();
                Mesh receivedMesh = DeserializeMesh(receivedMeshData);
                skinnedMeshRenderer.sharedMesh = receivedMesh;
            }
            else
            {
                skinnedMeshRenderer.sharedMesh = null;
            }

            material = (Material)stream.ReceiveNext();
            skinnedMeshRenderer.sharedMaterial = material;
        }
    }

    private byte[] SerializeMesh(Mesh mesh)
    {
        BinaryFormatter bf = new BinaryFormatter();
        using (MemoryStream ms = new MemoryStream())
        {
            bf.Serialize(ms, mesh);
            return ms.ToArray();
        }
    }

    private Mesh DeserializeMesh(byte[] data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        using (MemoryStream ms = new MemoryStream(data))
        {
            return (Mesh)bf.Deserialize(ms);
        }
    }
}
