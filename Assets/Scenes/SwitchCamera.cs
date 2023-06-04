using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    
   
    void Update() 
    {
        
        if (Input.GetKeyDown(KeyCode.C)) 
        {
            Debug.Log("User pressed C");
            if(cameraOne.activeSelf == true)
            {
                cameraOne.SetActive(false);
                cameraTwo.SetActive(true);

            }
            if(cameraTwo.activeSelf == true)
            {
                cameraTwo.SetActive(false);
                cameraOne.SetActive(true);

            }
           
        }
        
            
    }

    // AudioListener cameraOneAudioLis;
    // AudioListener cameraTwoAudioLis;

    // void Start()
    // {
    //     cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
    //     cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();

    //     cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     switchCamera();
        
    // }

    // public void cameraPositionM()
    // {
    //     cameraChangeCounter();
    // }

    // void switchCamera()
    // {
    //     if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt) )
    //     {
    //         cameraChangeCounter();
    //         Debug.Log("User pressed C");
    //     }


    // }

    // void cameraChangeCounter()
    // {

    //     int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
    //     cameraPositionCounter++;
    //     cameraPositionChange(cameraPositionCounter);


    // }

    // void cameraPositionChange (int camPosition)
    // {
    //     if (camPosition>1)
    //     {
    //         camPosition = 0;
    //     }
    //     PlayerPrefs.SetInt("CameraPosition", camPosition);

    //     if (camPosition ==0)
    //     {
    //         cameraOne.SetActive(true);
    //         cameraOneAudioLis.enabled = true;

    //         cameraTwoAudioLis.enabled = false;
    //         cameraTwo.SetActive(false);

    //     }

    //     if (camPosition == 1)
    //     {
    //         cameraTwo.SetActive(true);
    //         cameraTwoAudioLis.enabled = true;

    //         cameraOneAudioLis.enabled = false;
    //         cameraOne.SetActive(false);

    //     }


    // }
}
