using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerScript : MonoBehaviourPunCallbacks 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine)
        {
            //this is local client
            float x = Input.GetAxis("Horizontal")* 5f * Time.deltaTime;
            float z = Input.GetAxis("Vertical")* 5f * Time.deltaTime;
            transform.Translate(x,0,z);

        }
    }
}



































//A PhotonView identifies an object across the network (viewID) and configures how the controlling client updates remote instances.

