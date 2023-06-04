using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_size : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isScale;
    private float scaleSpeed;
    public Vector3 OrigineScale;
    public Vector3 newScale;
    [SerializeField]
    public FloatSO scoreSO;

    void Start()
    {
        OrigineScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (isScale)
        {

            newScale = transform.localScale;
            newScale.x += 1.8f * scaleSpeed * Time.deltaTime;

            if( scoreSO.Value == 0)
            {
                if(newScale.x >= 1)
                {
                    transform.localScale = newScale;
                }else
                {
                    Stop();
                }

            }
            if( scoreSO.Value == 1)
            {
                if(newScale.x >= 1.55f)
                {
                    transform.localScale = newScale;
                }else
                {
                    Stop();
                }

            }
            if( scoreSO.Value == 2)
            {
                if(newScale.x >= 2f)
                {
                    transform.localScale = newScale;
                }else
                {
                    Stop();
                }

            }
            
            

        }
       
    }

    public void ScaleCube(float speed)
    {
        
        if( scoreSO.Value == 0)
        {
            if(transform.localScale.x >= 1)
            {

                isScale = true;
                scaleSpeed = speed;

            }
            else
            {
                Stop();
            }

        }

        if( scoreSO.Value == 1)
        {
            if(transform.localScale.x >= 1.55f)
            {

                isScale = true;
                scaleSpeed = speed;

            }
            else
            {
                Stop();
            }

        }
        if( scoreSO.Value == 2)
        {
            if(transform.localScale.x >= 2.0f)
            {

                isScale = true;
                scaleSpeed = speed;

            }
            else
            {
                Stop();
            }

        }
        
        
        
    }

    public void Stop()
    {
        isScale = false;
    }
}
