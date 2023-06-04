using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadyPlayerMe;
using Photon.Pun;
using TMPro;
public class PlayerName : MonoBehaviourPunCallbacks
{
    
    private PhotonView photonView;
    public TMP_Text playerNameText;

    private void Start()
    {
        photonView = GetComponentInParent<PhotonView>();

        if (photonView != null && playerNameText != null)
        {
            playerNameText.text = photonView.Owner.NickName;
            Debug.Log("your Name is"+playerNameText.text);
        }
        else
        {
            Debug.LogError("PhotonView or Text component is missing.");
        }
    }
}
