using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairDetection : MonoBehaviour
{
    public bool canSit = false;
    string playerTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            canSit = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            canSit = false;
        }
    }

    private void Update()
    {
        //Debug.Log("can sit :" + canSit);
    }
}
