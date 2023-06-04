using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_change_board : MonoBehaviour
{
    public GameObject BlackBoard;
    public GameObject WhiteBoard;
    private GameObject  CurrentBoard;
    private GameObject  NewBoard;
    
    public void changeBoard()
    {

        if(BlackBoard.activeSelf == true)
        {
            CurrentBoard = BlackBoard;
            NewBoard = WhiteBoard;
        }
        if( WhiteBoard.activeSelf == true)
        {
            CurrentBoard = WhiteBoard;
            NewBoard = BlackBoard;
        }
        
        

        CurrentBoard.SetActive(false);
        NewBoard.SetActive(true);
        
        
    }
}
