using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADD_tables_IfFull : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject classroom_size;
    public GameObject Model1_chair_and_table;
    public GameObject Model2_chair_and_table;
    public GameObject Model3_chair_and_table;
    public GameObject Model4_chair_and_table;

    public GameObject column1Left1;
    public GameObject column2Left1;
    public GameObject column1Right1;
    public GameObject column2Right1;

    public GameObject column1Left3;
    public GameObject column2Left3;
    public GameObject column1Right3;
    public GameObject column2Right3;

    public GameObject column1Left4;
    public GameObject column2Left4;
    public GameObject column1Right4;
    public GameObject column2Right4;

    private GameObject current_Model_chair_and_table;
    private GameObject currentColumnLeft1;
    private GameObject currentColumnLeft2;
    private GameObject currentColumnRight1;
    private GameObject currentColumnRight2;
    [SerializeField]
    public FloatSO scoreSO;

    public Vector3 newScale;


    void Start()
    {
        FindCurrentModel();
        Debug.Log("User pressed" + scoreSO.Value);


    }


    public void FindCurrentModel()
    {

        if( Model1_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model1_chair_and_table;
            currentColumnLeft1 = column1Left1;
            currentColumnLeft2 = column2Left1;
            currentColumnRight1 = column1Right1;
            currentColumnRight2 = column2Right1;

        }
        if( Model2_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model2_chair_and_table;
            
        }
        if( Model3_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model3_chair_and_table;
            currentColumnLeft1 = column1Left3;
            currentColumnLeft2 = column2Left3;
            currentColumnRight1 = column1Right3;
            currentColumnRight2 = column2Right3;
        }
        if( Model4_chair_and_table.activeSelf == true)
        {
            current_Model_chair_and_table = Model4_chair_and_table;
            currentColumnLeft1 = column1Left4;
            currentColumnLeft2 = column2Left4;
            currentColumnRight1 = column1Right4;
            currentColumnRight2 = column2Right4;
        }

        if(scoreSO.Value == 1)
        {
            newScale = classroom_size.transform.localScale;
            newScale.x = 1.55f;
            newScale.z = 1.13f;
            classroom_size.transform.localScale = newScale;
            currentColumnLeft1.SetActive(true);
            currentColumnRight1.SetActive(true);
            


        }
        if(scoreSO.Value == 2)
        {
            newScale = classroom_size.transform.localScale;
            newScale.x = 2f;
            newScale.z = 1.12f;
            classroom_size.transform.localScale = newScale;
            currentColumnLeft1.SetActive(true);
            currentColumnRight1.SetActive(true);
            currentColumnLeft2.SetActive(true);
            currentColumnRight2.SetActive(true);

        }


        
    }


    
}
