using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class etudInsert : MonoBehaviour
{
    public Button btnClick;
    string URL = "http://localhost/unity/etudInsert.php";
    public InputField InputNom, InputPrenom;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void GetInputOnclickHandler()
    {
        Debug.Log("Nom : "+InputNom.text);
        string nom = InputNom.text;
        Debug.Log("Prenom: " + InputPrenom.text);
        string prenom = InputPrenom.text;
        // Debug.Log("Num: " + InputNum.text);
        // string num = InputNum.text;
        AddUser(nom, prenom, 1);

        

    }
    public void AddUser(string nom, string prenom, int num)
    {
        WWWForm form = new WWWForm();
        form.AddField("addNom", nom);
        form.AddField("addPrenom", prenom);
        form.AddField("addNum", 1);
        WWW www = new WWW(URL, form);
    }

     public void home()
    {
        SceneManager.LoadScene(1);
    }

}
