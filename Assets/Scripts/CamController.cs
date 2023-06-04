using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CamController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vCam;
    [SerializeField] private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        vCam=CinemachineVirtualCamera.FindObjectOfType<CinemachineVirtualCamera>();
        vCam=GetComponentInChildren<CinemachineVirtualCamera>();
        vCam.m_Lens.FieldOfView=60;
        target=GameObject.FindGameObjectsWithTag("target")[0];
        vCam.m_LookAt=target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
