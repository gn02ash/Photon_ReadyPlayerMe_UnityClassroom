using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model1ChairsAndTables : MonoBehaviour
{
    // public GameObject Models_chairs_and_tables;
    [SerializeField]
    public FloatSO scoreSO;
    public GameObject Model1_chair_and_table;
    

    public GameObject Model2_chair_and_table;

    public GameObject Model3_chair_and_table;
    

    public GameObject Model4_chair_and_table;
    
    public GameObject Panel_Imgs_chair_tables;

    private GameObject current_Model_chair_and_table;

    

    public void OpenModel(GameObject new_Model_chair_and_table)
    {
        


        if( Model1_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model1_chair_and_table;
        }
        if( Model2_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model2_chair_and_table;
        }
        if( Model3_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model3_chair_and_table;
        }
        if( Model4_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model4_chair_and_table;
        }

        current_Model_chair_and_table.SetActive(false);
        new_Model_chair_and_table.SetActive(true);

        
        

        
        
    }

    public void OpenLeft1(GameObject Left1model)
    {
        if(scoreSO.Value == 1 ||  scoreSO.Value == 2)
        {
            Left1model.SetActive(true);
            
        }

    }
    public void OpenRight1(GameObject Right1model)
    {
        if(scoreSO.Value == 1  ||  scoreSO.Value == 2)
        {
            Right1model.SetActive(true);
            
        }

    }

    public void OpenLeft2(GameObject Left2model)
    {
        if(scoreSO.Value == 2)
        {
            Left2model.SetActive(true);
            
        }
    

    }

    public void OpenRight2(GameObject Right2model)
    {
    
        if(scoreSO.Value == 2)
        {
            Right2model.SetActive(true);
            
        }

    }



    public void save_model()
    {
        Panel_Imgs_chair_tables.SetActive(false);

    }

    public void reset_model()
    {
        Model1_chair_and_table.SetActive(false);
        Model2_chair_and_table.SetActive(false);
        Model3_chair_and_table.SetActive(false);
        Model4_chair_and_table.SetActive(true);

        Panel_Imgs_chair_tables.SetActive(false);

    }
}
