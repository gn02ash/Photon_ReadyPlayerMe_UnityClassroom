using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StopPlayerMovement : MonoBehaviour
{
    
    public bool stop = false;
    private CinemachineFreeLook _cinemachineFreeLook;

    public GameObject cameraOne;
    public GameObject cameraTwo;
    // public bool switchCam = false;
    private GameObject currentCam;
    private GameObject NewCam;
    
    void Start()
    {
        _cinemachineFreeLook = GetComponent<CinemachineFreeLook>();
    }
    

    void Update() 
    {
        
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            Debug.Log("User pressed X");
            stop = true;
           
        }
        if (Input.GetKeyDown(KeyCode.M)) 
        {
            Debug.Log("User pressed M");
            stop = false;
           
        }

        if (stop == true)
        {
            _cinemachineFreeLook.enabled = false;
        }
        else
        {
            _cinemachineFreeLook.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.S)) 
        {
            Debug.Log("User pressed S");
            SwitchCamera();
           
        }
    
                
            
    }

    public void SwitchCamera()
    {
        if(cameraOne.activeSelf == true)
            {
                currentCam = cameraOne;
                NewCam = cameraTwo;

            }
            if(cameraTwo.activeSelf == true)
            {
                currentCam = cameraTwo;
                NewCam = cameraOne;

            }

            currentCam.SetActive(false);
            NewCam.SetActive(true);

    }

   
}
