using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_change_class_size : MonoBehaviour
{
    public GameObject Menu_change_size_class;
    public void OpenMenu_change_size_class()
    {
        if (Menu_change_size_class !=null)
        {
            bool isActive=Menu_change_size_class.activeSelf;
            Menu_change_size_class.SetActive(!isActive);
        }
    }
}
