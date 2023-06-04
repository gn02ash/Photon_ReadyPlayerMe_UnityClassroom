using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class SceneSpawner : MonoBehaviourPunCallbacks
{
    public string sceneName = "YourSceneName";

    void Start()
    {
        // Connect to Photon server
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon server");
        // Create or join a room
        PhotonNetwork.JoinOrCreateRoom("YourRoomName", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room");
        // Load the scene for all clients
        PhotonNetwork.LoadLevel(sceneName);
    }
}
