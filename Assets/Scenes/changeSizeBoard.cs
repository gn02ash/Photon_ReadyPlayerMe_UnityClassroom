using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSizeBoard : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isScale;
    private float scaleSpeed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isScale)
        {

            var newScale = transform.localScale;
            newScale.z += 1f * scaleSpeed * Time.deltaTime;
            newScale.y += 1f * scaleSpeed * Time.deltaTime;
            transform.localScale = newScale;

        }
       
    }

     public void ScaleCube(float speed)
    {
        isScale = true;
        scaleSpeed = speed;
    }

    public void Stop()
    {
        isScale = false;
    }
}
