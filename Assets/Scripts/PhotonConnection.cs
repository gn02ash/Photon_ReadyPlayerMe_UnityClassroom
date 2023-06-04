using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class PhotonConnection : MonoBehaviourPunCallbacks
{
     [SerializeField]
    private GameObject canvas;
    public TMP_InputField PlayerName;
    public PhotonView PlayerPrefab;
    string URL ;
    private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }
    // Start is called before the first frame update
    void Start()
    {
        //Load the subdomain of readyplayerMe Partner
        #if !UNITY_EDITOR && UNITY_WEBGL
        PartnerSO partner = Resources.Load<PartnerSO>("Partner");
        
        WebInterface.SetupRpmFrame(partner.Subdomain);
        #endif
       
    }

    public override void  OnConnectedToMaster(){
        Debug.Log("Connected to master");
        //set room options
        RoomOptions roomOptions = new RoomOptions();
        //max 10 players per room
        roomOptions.MaxPlayers = 10;
        PhotonNetwork.JoinOrCreateRoom("EnsamMeta", roomOptions, TypedLobby.Default);
    }
    public override void OnJoinedRoom(){
        Debug.Log("Joined ROOM");
        GameObject character = PhotonNetwork.Instantiate(PlayerPrefab.name,Vector3.zero,Quaternion.identity);
        
    }
     public void OnCreateAvatar(){
        PhotonNetwork.NickName=PlayerName.text;
        Debug.Log(PhotonNetwork.NickName);
        PhotonNetwork.ConnectUsingSettings();
        canvas.SetActive(false);
        #if !UNITY_EDITOR && UNITY_WEBGL
        WebInterface.SetIFrameVisibility(true);
        #endif
    }
    
}
