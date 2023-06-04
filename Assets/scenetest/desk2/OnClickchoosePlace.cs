using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickchoosePlace : MonoBehaviour
{
    public GameObject panel_places;
    public void Openpanel_places()
    {
        if (panel_places !=null)
        {
            bool isActive=panel_places.activeSelf;
            panel_places.SetActive(!isActive);
        }
    }
}
