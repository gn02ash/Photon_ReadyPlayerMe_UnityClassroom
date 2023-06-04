using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_change_desk : MonoBehaviour
{
    public GameObject Menu_desks;
    public void OpenMenu_desks()
    {
        if (Menu_desks !=null)
        {
            bool isActive=Menu_desks.activeSelf;
            Menu_desks.SetActive(!isActive);
        }
    }
}
