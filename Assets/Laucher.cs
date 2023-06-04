using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Laucher : MonoBehaviourPunCallbacks
{
    public PhotonView PlayerPrefab;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
/*         PlayerPrefab=GameObject.FindGameObjectWithTag("target").GetComponent<PhotonView>();
 */    }

    // Update is called once per frame
    public override void  OnConnectedToMaster(){
        Debug.Log("Connected to master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
    public override void OnJoinedRoom(){
        Debug.Log("Joined ROOM");
        PhotonNetwork.Instantiate(PlayerPrefab.name,Vector3.zero,Quaternion.identity);
        Player.SetActive(true);
    }
}
