using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_change_chairs_tables : MonoBehaviour
{
    public GameObject Menu_chairs_tables;
    public void OpenMenu_chairs_tables()
    {
        if (Menu_chairs_tables !=null)
        {
            bool isActive=Menu_chairs_tables.activeSelf;
            Menu_chairs_tables.SetActive(!isActive);
        }
    }
}
