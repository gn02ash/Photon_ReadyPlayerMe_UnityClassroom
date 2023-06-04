using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickWihteBoard : MonoBehaviour
{
    public GameObject BlackBoard;
    public GameObject WhiteBoard;
    
   
    void  OnMouseDown() 
    {
        WhiteBoard.SetActive(false);
        BlackBoard.SetActive(true);
    
    }
}
