using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonChangeWallsColor : MonoBehaviour
{
   public GameObject ColorPicker;
//    private Color customColor = new Color(1.0f, 1.0f, 0.9098039f, 1.0f);
   public void OpenColorPicker()
   {
    if (ColorPicker !=null)
    {
        bool isActive=ColorPicker.activeSelf;
        ColorPicker.SetActive(!isActive);
    }
   }

   public void saveColor()
   {
        ColorPicker.SetActive(false);
   }

   public void resetColor(Material change_color)
   {
       

       change_color.color = Color.white;
       ColorPicker.SetActive(false);
   }
}
