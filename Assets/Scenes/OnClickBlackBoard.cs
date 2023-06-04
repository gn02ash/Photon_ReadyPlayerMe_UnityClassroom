using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickBlackBoard : MonoBehaviour
{
    public GameObject BlackBoard;
    public GameObject WhiteBoard;
    
   
    void  OnMouseDown() 
    {
        WhiteBoard.SetActive(true);
        BlackBoard.SetActive(false);
    
    }
}
