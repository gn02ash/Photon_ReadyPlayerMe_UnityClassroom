using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_model_desk : MonoBehaviour
{
    public GameObject Model1_desk;
    public GameObject Model2_desk;
    public GameObject Model3_desk;
    public GameObject Panel_Imgs_desks;

    private GameObject current_Model_desk;

    public void OpenModel(GameObject new_Model_desk)
    {

        if( Model1_desk.activeSelf == true)
        {
            current_Model_desk = Model1_desk;
        }
        if( Model2_desk.activeSelf == true)
        {
            current_Model_desk = Model2_desk;
        }
        if( Model3_desk.activeSelf == true)
        {
            current_Model_desk = Model3_desk;
        }
        

        current_Model_desk.SetActive(false);
        new_Model_desk.SetActive(true);
        
        
    }

    public void save_model()
    {
        Panel_Imgs_desks.SetActive(false);

    }

    public void reset_model()
    {
        Model1_desk.SetActive(false);
        Model2_desk.SetActive(false);
        Model3_desk.SetActive(true);
        
        Panel_Imgs_desks.SetActive(false);

    }
}
