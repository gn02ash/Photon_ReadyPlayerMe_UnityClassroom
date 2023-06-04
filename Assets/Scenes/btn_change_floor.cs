using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_change_floor : MonoBehaviour
{
   public GameObject Menu_floor;
   public void OpenMenu_floor()
   {
    if (Menu_floor !=null)
    {
        bool isActive=Menu_floor.activeSelf;
        Menu_floor.SetActive(!isActive);
    }
   }
}
