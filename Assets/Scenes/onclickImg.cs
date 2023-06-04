using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class onclickImg : MonoBehaviour
{

    
    public Sprite Accept_Icon;
    public Sprite Close_Icon;
    Image mapButton;
    // Start is called before the first frame update
    void Start()
    {
        mapButton = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSprite()
    {
        // getting Image component of mapButton and changing it
        mapButton.sprite = Close_Icon;
    }
}
