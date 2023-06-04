using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{


    public Color myColor;
    public Renderer myRenderer;
    private Vector3 scaleChange;


    // Start is called before the first frame update
    void Start()
    {
        
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.R))
        {
            myColor = new Color(1, 0, 0, 1);
            myRenderer.material.color = myColor;
        }


        if (Input.GetKey(KeyCode.G))
        {
            myColor = new Color(0, 1, 0, 1);
            myRenderer.material.color = myColor;
        }
        if (Input.GetKey(KeyCode.B))
        {
            myColor = new Color(0, 0, 1, 1);
            myRenderer.material.color = myColor;
        }

        if (Input.GetKey(KeyCode.T))
        {
            scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
            myRenderer.transform.localScale += scaleChange;
        }
        

        
    }
}
