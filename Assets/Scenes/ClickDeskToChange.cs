using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDeskToChange : MonoBehaviour
{
   public GameObject Images_desk_panel;
    
   
   void  OnMouseDown() 
   {

       Images_desk_panel.SetActive(true);
    
   }
}
