using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class script1 : MonoBehaviour
{ 


    public Button btnClick;
    string URL = "http://localhost/unity/etudInsert.php";
    string URL1 = "http://localhost/unity/userSelect.php";
    public string[] usersData;
    public InputField InputNum;
    public GameObject P1, P2, P3, P4;
    public int cmp = 0;
    [SerializeField] Image On1;
    [SerializeField] Image Off1;
    [SerializeField] Image On2;
    [SerializeField] Image Off2;
    [SerializeField] Image On3;
    [SerializeField] Image Off3;
    [SerializeField] Image On4;
    [SerializeField] Image Off4;
    [SerializeField] Image On5;
    [SerializeField] Image Off5;
    [SerializeField] Image On6;
    [SerializeField] Image Off6;
    [SerializeField] Image On7;
    [SerializeField] Image Off7;
    [SerializeField] Image On8;
    [SerializeField] Image Off8;
    [SerializeField] Image On9;
    [SerializeField] Image Off9;
    [SerializeField] Image On10;
    [SerializeField] Image Off10;
    [SerializeField] Image On11;
    [SerializeField] Image Off11;
    [SerializeField] Image On12;
    [SerializeField] Image Off12;
    [SerializeField] Image On13;
    [SerializeField] Image Off13;
    [SerializeField] Image On14;
    [SerializeField] Image Off14;
    [SerializeField] Image On15;
    [SerializeField] Image Off15;
    [SerializeField] Image On16;
    [SerializeField] Image Off16;
    [SerializeField] Image On17;
    [SerializeField] Image Off17;
    [SerializeField] Image On18;
    [SerializeField] Image Off18;
    [SerializeField] Image On19;
    [SerializeField] Image Off19;
    [SerializeField] Image On20;
    [SerializeField] Image Off20;
    [SerializeField] Image On21;
    [SerializeField] Image Off21;
    [SerializeField] Image On22;
    [SerializeField] Image Off22;
    [SerializeField] Image On23;
    [SerializeField] Image Off23;
    [SerializeField] Image On24;
    [SerializeField] Image Off24;
    [SerializeField] Image On25;
    [SerializeField] Image Off25;
    [SerializeField] Image On26;
    [SerializeField] Image Off26;
    [SerializeField] Image On27;
    [SerializeField] Image Off27;
    [SerializeField] Image On28;
    [SerializeField] Image Off28;
    [SerializeField] Image On29;
    [SerializeField] Image Off29;
    [SerializeField] Image On30;
    [SerializeField] Image Off30;
    [SerializeField] Image On31;
    [SerializeField] Image Off31;
    [SerializeField] Image On32;
    [SerializeField] Image Off32;

    //List<Item> items = new List();
    //List<Item> items1 = new List();
    private bool muted = false;
    public string num;
    [SerializeField]
    public FloatSO scoreSO;

    [SerializeField]
    public FloatSO numtableSO;
    public int i = 0;
    public List<Image> unityOn = new List<Image>();
    public List<Image> unityOff = new List<Image>();




    IEnumerator Start()
    {
        // Panel.gameObject.SetActive(false);
        //On
        unityOn.Add(On1);
        unityOn.Add(On2);
        unityOn.Add(On3);
        unityOn.Add(On4);
        unityOn.Add(On5);
        unityOn.Add(On6);
        unityOn.Add(On7);
        unityOn.Add(On8);
        unityOn.Add(On9);
        unityOn.Add(On10);
        unityOn.Add(On11);
        unityOn.Add(On12);
        unityOn.Add(On13);
        unityOn.Add(On14);
        unityOn.Add(On15);
        unityOn.Add(On16);
        unityOn.Add(On17);
        unityOn.Add(On18);
        unityOn.Add(On19);
        unityOn.Add(On20);
        unityOn.Add(On21);
        unityOn.Add(On22);
        unityOn.Add(On23);
        unityOn.Add(On24);
        unityOn.Add(On25);
        unityOn.Add(On26);
        unityOn.Add(On27);
        unityOn.Add(On28);
        unityOn.Add(On29);
        unityOn.Add(On30);
        unityOn.Add(On31);
        unityOn.Add(On32);


        //Off

        unityOff.Add(Off1);
        unityOff.Add(Off2);
        unityOff.Add(Off3);
        unityOff.Add(Off4);
        unityOff.Add(Off5);
        unityOff.Add(Off6);
        unityOff.Add(Off7);
        unityOff.Add(Off8);
        unityOff.Add(Off9);
        unityOff.Add(Off10);
        unityOff.Add(Off11);
        unityOff.Add(Off12);
        unityOff.Add(Off13);
        unityOff.Add(Off14);
        unityOff.Add(Off15);
        unityOff.Add(Off16);
        unityOff.Add(Off17);
        unityOff.Add(Off18);
        unityOff.Add(Off19);
        unityOff.Add(Off20);
        unityOff.Add(Off21);
        unityOff.Add(Off22);
        unityOff.Add(Off23);
        unityOff.Add(Off24);
        unityOff.Add(Off17);
        unityOff.Add(Off18);
        unityOff.Add(Off19);
        unityOff.Add(Off20);
        unityOff.Add(Off21);
        unityOff.Add(Off22);
        unityOff.Add(Off23);
        unityOff.Add(Off24);
        unityOff.Add(Off25);
        unityOff.Add(Off26);
        unityOff.Add(Off27);
        unityOff.Add(Off28);
        unityOff.Add(Off29);
        unityOff.Add(Off30);
        unityOff.Add(Off31);
        unityOff.Add(Off32);

        WWW users = new WWW(URL1);
        yield return users;
        string usersDataString = users.text;
        usersData = usersDataString.Split(';');
        object n = GetValueData(usersData[0], "cn");
        print(n);
        //int nbr = int.Parse(n.ToString());
        //Get the number of table by id 
        for (int i = 1; i <33; i++)
        {
            string table = "c" + i;
            print("////////////////");
            print("Table: " + table);
            object p = GetValueData(usersData[0], table);
            print(p);

            string p1 = p.ToString();
            if (p1 == "0")
            {


            }
            else
            {
                cmp = cmp + 1;
            }

        }

        print("\n##################CMPPPPPPPPPPPPPPPP: " + cmp + "##################\n############################");
        if (cmp < 16)
        {
            P1.gameObject.SetActive(false);
            P2.gameObject.SetActive(false);
            P3.gameObject.SetActive(false);
            P4.gameObject.SetActive(false);


        }

        else
        {
            if (cmp < 24)
            {

                P1.gameObject.SetActive(true);
                P2.gameObject.SetActive(true);
                P3.gameObject.SetActive(false);
                P4.gameObject.SetActive(false);
                scoreSO.Value = 1;
            }
            else
            {
                P1.gameObject.SetActive(true);
                P2.gameObject.SetActive(true);
                P3.gameObject.SetActive(true);
                P4.gameObject.SetActive(true);
                scoreSO.Value = 2;
            }
        }


        //Get Data to know if the chair is disponible or not 
        for (int i = 1; i < 25; i++)
        {
            string table = "c" + i;
            print("////////////////");
            print("Table: " + table);
            object p = GetValueData(usersData[0], table);
            print(p);


            //string p1 = p.ToString();
            string p1 = p.ToString();
            print("HHHHHHHH: " + p1);
            //int n1 = int.Parse(p1);
            //print("INNNNNNNNNNNNNNNNT" + n1);

            if (p1 == "0")
            {
                Debug.Log("Table disponible");
                unityOff[i - 1].enabled = false;
            }
            else
            {
                Debug.Log("Table non disponible");
                unityOn[i - 1].enabled = false;


            }

        }

        /*Off1.enabled = false;
        Off2.enabled = false;
        Off3.enabled = false;
        Off4.enabled = false;
        Off5.enabled = false;
        Off6.enabled = false;
        Off7.enabled = false;
        Off8.enabled = false;
        Off9.enabled = false;
        Off10.enabled = false;
        Off11.enabled = false;
        Off12.enabled = false;
        Off13.enabled = false;
        Off14.enabled = false;
        Off15.enabled = false;
        Off16.enabled = false;*/



    }

    string GetValueData(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);

        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));
        }

        return value;

    }

    /*public void Start()
    {
        Off1.enabled = false;
        Off2.enabled = false;
        Off3.enabled = false;
        Off4.enabled = false;
        Off5.enabled = false;
        Off6.enabled = false;
        Off7.enabled = false;
        Off8.enabled = false;
        Off9.enabled = false;
        Off10.enabled = false;
        Off11.enabled = false;
        Off12.enabled = false;
        Off13.enabled = false;
        Off14.enabled = false;
        Off15.enabled = false;
        Off16.enabled = false;

        Panel.gameObject.SetActive(true);
    }*/
    public void OnButtonPress1()
    {
        i = i + 1;
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon1();
    }
    public void OnButtonPress2()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton1 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton1.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);

        }
        else
        {
            muted = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon2();
    }
    public void OnButtonPress3()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton1.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon3();
    }

    public void OnButtonPress4()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton1.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon4();
    }

    public void OnButtonPress5()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton1.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon5();
    }

    public void OnButtonPress6()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton1.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon6();
    }

    public void OnButtonPress7()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton1.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon7();
    }
    public void OnButtonPress8()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton1.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon8();
    }

    public void OnButtonPress9()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("1").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton1.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon9();
    }

    public void OnButtonPress10()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("1").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton1.enabled = false;
            yourButton11.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon10();
    }

    public void OnButtonPress11()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("1").GetComponent<Button>();
            Button yourButton12 = GameObject.Find("12").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton1.enabled = false;
            yourButton12.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;

            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }


        //Save();
        UpdateButtonIcon11();
    }

    public void OnButtonPress12()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;
            Button yourButton2 = GameObject.Find("2").GetComponent<Button>();
            Button yourButton3 = GameObject.Find("3").GetComponent<Button>();
            Button yourButton4 = GameObject.Find("4").GetComponent<Button>();
            Button yourButton5 = GameObject.Find("5").GetComponent<Button>();
            Button yourButton6 = GameObject.Find("6").GetComponent<Button>();
            Button yourButton7 = GameObject.Find("7").GetComponent<Button>();
            Button yourButton8 = GameObject.Find("8").GetComponent<Button>();
            Button yourButton9 = GameObject.Find("9").GetComponent<Button>();
            Button yourButton10 = GameObject.Find("10").GetComponent<Button>();
            Button yourButton11 = GameObject.Find("11").GetComponent<Button>();
            Button yourButton1 = GameObject.Find("1").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("13").GetComponent<Button>();
            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton2.enabled = false;
            yourButton3.enabled = false;
            yourButton4.enabled = false;
            yourButton5.enabled = false;
            yourButton6.enabled = false;
            yourButton7.enabled = false;
            yourButton8.enabled = false;
            yourButton9.enabled = false;
            yourButton10.enabled = false;
            yourButton11.enabled = false;
            yourButton1.enabled = false;
            yourButton13.enabled = false;
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }
    }
    public void OnButtonPress13()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon13();
    }

    public void OnButtonPress14()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton13 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton13.enabled = false;
            yourButton15.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon14();
    }

    public void OnButtonPress15()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton16 = GameObject.Find("16").GetComponent<Button>();
            yourButton14.enabled = false;
            yourButton13.enabled = false;
            yourButton16.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon15();
    }

    public void OnButtonPress16()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton14 = GameObject.Find("14").GetComponent<Button>();
            Button yourButton15 = GameObject.Find("15").GetComponent<Button>();
            Button yourButton13 = GameObject.Find("16").GetComponent<Button>();
            yourButton14.enabled = false;
            yourButton15.enabled = false;
            yourButton13.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon16();
    }


    public void OnButtonPress17()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton19.enabled = false;
            yourButton20.enabled = false;
            yourButton21.enabled = false;
            yourButton22.enabled = false;
            yourButton23.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon17();
    }

    public void OnButtonPress18()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton17.enabled = false;
            yourButton19.enabled = false;
            yourButton20.enabled = false;
            yourButton21.enabled = false;
            yourButton22.enabled = false;
            yourButton23.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon18();
    }


    public void OnButtonPress19()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton17.enabled = false;
            yourButton20.enabled = false;
            yourButton21.enabled = false;
            yourButton22.enabled = false;
            yourButton23.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon19();
    }



    public void OnButtonPress20()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton19.enabled = false;
            yourButton17.enabled = false;
            yourButton21.enabled = false;
            yourButton22.enabled = false;
            yourButton23.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon20();
    }

    public void OnButtonPress21()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton19.enabled = false;
            yourButton20.enabled = false;
            yourButton17.enabled = false;
            yourButton22.enabled = false;
            yourButton23.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon21();
    }

    public void OnButtonPress22()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton19.enabled = false;
            yourButton20.enabled = false;
            yourButton21.enabled = false;
            yourButton17.enabled = false;
            yourButton23.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon22();
    }

    public void OnButtonPress23()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            Button yourButton24 = GameObject.Find("24").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton19.enabled = false;
            yourButton20.enabled = false;
            yourButton21.enabled = false;
            yourButton22.enabled = false;
            yourButton17.enabled = false;
            yourButton24.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon23();
    }


    public void OnButtonPress24()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;

            Button yourButton18 = GameObject.Find("18").GetComponent<Button>();
            Button yourButton19 = GameObject.Find("19").GetComponent<Button>();
            Button yourButton20 = GameObject.Find("20").GetComponent<Button>();
            Button yourButton21 = GameObject.Find("21").GetComponent<Button>();
            Button yourButton22 = GameObject.Find("22").GetComponent<Button>();
            Button yourButton23 = GameObject.Find("23").GetComponent<Button>();
            Button yourButton17 = GameObject.Find("17").GetComponent<Button>();
            yourButton18.enabled = false;
            yourButton19.enabled = false;
            yourButton20.enabled = false;
            yourButton21.enabled = false;
            yourButton22.enabled = false;
            yourButton23.enabled = false;
            yourButton17.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon24();
    }


    public void OnButtonPress25()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Debug.Log("NUMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" + num);
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton26.enabled = false;
            yourButton27.enabled = false;
            yourButton28.enabled = false;
            yourButton29.enabled = false;
            yourButton30.enabled = false;
            yourButton31.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon25();
    }


    public void OnButtonPress26()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton27.enabled = false;
            yourButton28.enabled = false;
            yourButton29.enabled = false;
            yourButton30.enabled = false;
            yourButton31.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon26();
    }


    public void OnButtonPress27()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton26.enabled = false;
            yourButton28.enabled = false;
            yourButton29.enabled = false;
            yourButton30.enabled = false;
            yourButton31.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon27();
    }


     
    public void OnButtonPress28()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton26.enabled = false;
            yourButton27.enabled = false;
            yourButton29.enabled = false;
            yourButton30.enabled = false;
            yourButton31.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon28();
    }

    public void OnButtonPress29()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton26.enabled = false;
            yourButton28.enabled = false;
            yourButton27.enabled = false;
            yourButton30.enabled = false;
            yourButton31.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon29();
    }


    public void OnButtonPress30()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton26.enabled = false;
            yourButton28.enabled = false;
            yourButton29.enabled = false;
            yourButton27.enabled = false;
            yourButton31.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon30();
    }

    public void OnButtonPress31()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            Button yourButton32 = GameObject.Find("32").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton26.enabled = false;
            yourButton28.enabled = false;
            yourButton29.enabled = false;
            yourButton30.enabled = false;
            yourButton27.enabled = false;
            yourButton32.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon31();
    }

    public void OnButtonPress32()
    {
        if (muted == false)
        {
            muted = true;
            num = EventSystem.current.currentSelectedGameObject.name;
            Button yourButton = GameObject.Find(num).GetComponent<Button>();
            yourButton.enabled = false;


            Button yourButton25 = GameObject.Find("25").GetComponent<Button>();
            Button yourButton26 = GameObject.Find("26").GetComponent<Button>();
            Button yourButton28 = GameObject.Find("28").GetComponent<Button>();
            Button yourButton29 = GameObject.Find("29").GetComponent<Button>();
            Button yourButton30 = GameObject.Find("30").GetComponent<Button>();
            Button yourButton31 = GameObject.Find("31").GetComponent<Button>();
            Button yourButton27 = GameObject.Find("27").GetComponent<Button>();
            yourButton25.enabled = false;
            yourButton26.enabled = false;
            yourButton28.enabled = false;
            yourButton29.enabled = false;
            yourButton30.enabled = false;
            yourButton31.enabled = false;
            yourButton27.enabled = false;
            Debug.Log("Name : " + num);
            //AudioListener.pause = true;
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            num = "none";
        }

        //Save();
        UpdateButtonIcon32();
    }
    public void UpdateButtonIcon1()
    {
        if (muted == false)
        {
            On1.enabled = true;
            Off1.enabled = false;
        }
        else
        {
            On1.enabled = false;
            Off1.enabled = true;
        }
    }
    public void UpdateButtonIcon2()
    {
        if (muted == false)
        {
            On2.enabled = true;
            Off2.enabled = false;
        }
        else
        {
            On2.enabled = false;
            Off2.enabled = true;
        }
    }

    public void UpdateButtonIcon3()
    {
        if (muted == false)
        {
            On3.enabled = true;
            Off3.enabled = false;
        }
        else
        {
            On3.enabled = false;
            Off3.enabled = true;
        }
    }

    public void UpdateButtonIcon4()
    {
        if (muted == false)
        {
            On4.enabled = true;
            Off4.enabled = false;
        }
        else
        {
            On4.enabled = false;
            Off4.enabled = true;
        }
    }

    public void UpdateButtonIcon5()
    {
        if (muted == false)
        {
            On5.enabled = true;
            Off5.enabled = false;
        }
        else
        {
            On5.enabled = false;
            Off5.enabled = true;
        }
    }

    public void UpdateButtonIcon6()
    {
        if (muted == false)
        {
            On6.enabled = true;
            Off6.enabled = false;
        }
        else
        {
            On6.enabled = false;
            Off6.enabled = true;
        }
    }

    public void UpdateButtonIcon7()
    {
        if (muted == false)
        {
            On7.enabled = true;
            Off7.enabled = false;
        }
        else
        {
            On7.enabled = false;
            Off7.enabled = true;
        }
    }

    public void UpdateButtonIcon8()
    {
        if (muted == false)
        {
            On8.enabled = true;
            Off8.enabled = false;
        }
        else
        {
            On8.enabled = false;
            Off8.enabled = true;
        }
    }

    public void UpdateButtonIcon9()
    {
        if (muted == false)
        {
            On9.enabled = true;
            Off9.enabled = false;
        }
        else
        {
            On9.enabled = false;
            Off9.enabled = true;
        }
    }

    public void UpdateButtonIcon10()
    {
        if (muted == false)
        {
            On10.enabled = true;
            Off10.enabled = false;
        }
        else
        {
            On10.enabled = false;
            Off10.enabled = true;
        }
    }

    public void UpdateButtonIcon11()
    {
        if (muted == false)
        {
            On11.enabled = true;
            Off11.enabled = false;
        }
        else
        {
            On11.enabled = false;
            Off11.enabled = true;
        }
    }

    public void UpdateButtonIcon12()
    {
        if (muted == false)
        {
            On12.enabled = true;
            Off12.enabled = false;
        }
        else
        {
            On12.enabled = false;
            Off12.enabled = true;
        }
    }

    public void UpdateButtonIcon13()
    {
        if (muted == false)
        {
            On13.enabled = true;
            Off13.enabled = false;
        }
        else
        {
            On13.enabled = false;
            Off13.enabled = true;
        }
    }

    public void UpdateButtonIcon14()
    {
        if (muted == false)
        {
            On14.enabled = true;
            Off14.enabled = false;
        }
        else
        {
            On14.enabled = false;
            Off14.enabled = true;
        }
    }

    public void UpdateButtonIcon15()
    {
        if (muted == false)
        {
            On15.enabled = true;
            Off15.enabled = false;
        }
        else
        {
            On15.enabled = false;
            Off15.enabled = true;
        }
    }

    public void UpdateButtonIcon16()
    {
        if (muted == false)
        {
            On16.enabled = true;
            Off16.enabled = false;
        }
        else
        {
            On16.enabled = false;
            Off16.enabled = true;
        }
    }
    public void UpdateButtonIcon17()
    {
        if (muted == false)
        {
            On17.enabled = true;
            Off17.enabled = false;
        }
        else
        {
            On17.enabled = false;
            Off17.enabled = true;
        }
    }
    public void UpdateButtonIcon18()
    {
        if (muted == false)
        {
            On18.enabled = true;
            Off18.enabled = false;
        }
        else
        {
            On18.enabled = false;
            Off18.enabled = true;
        }
    }

    public void UpdateButtonIcon19()
    {
        if (muted == false)
        {
            On19.enabled = true;
            Off19.enabled = false;
        }
        else
        {
            On19.enabled = false;
            Off19.enabled = true;
        }
    }

    public void UpdateButtonIcon20()
    {
        if (muted == false)
        {
            On20.enabled = true;
            Off20.enabled = false;
        }
        else
        {
            On20.enabled = false;
            Off20.enabled = true;
        }
    }

    public void UpdateButtonIcon21()
    {
        if (muted == false)
        {
            On21.enabled = true;
            Off21.enabled = false;
        }
        else
        {
            On21.enabled = false;
            Off21.enabled = true;
        }
    }

    public void UpdateButtonIcon22()
    {
        if (muted == false)
        {
            On22.enabled = true;
            Off22.enabled = false;
        }
        else
        {
            On22.enabled = false;
            Off22.enabled = true;
        }
    }

    public void UpdateButtonIcon23()
    {
        if (muted == false)
        {
            On23.enabled = true;
            Off23.enabled = false;
        }
        else
        {
            On23.enabled = false;
            Off23.enabled = true;
        }
    }

    public void UpdateButtonIcon24()
    {
        if (muted == false)
        {
            On24.enabled = true;
            Off24.enabled = false;
        }
        else
        {
            On24.enabled = false;
            Off24.enabled = true;
        }
    }
    public void UpdateButtonIcon25()
    {
        if (muted == false)
        {
            On25.enabled = true;
            Off25.enabled = false;
        }
        else
        {
            On25.enabled = false;
            Off25.enabled = true;
        }
    }
    public void UpdateButtonIcon26()
    {
        if (muted == false)
        {
            On26.enabled = true;
            Off26.enabled = false;
        }
        else
        {
            On26.enabled = false;
            Off26.enabled = true;
        }
    }
    public void UpdateButtonIcon27()
    {
        if (muted == false)
        {
            On27.enabled = true;
            Off27.enabled = false;
        }
        else
        {
            On27.enabled = false;
            Off27.enabled = true;
        }
    }
    public void UpdateButtonIcon28()
    {
        if (muted == false)
        {
            On28.enabled = true;
            Off28.enabled = false;
        }
        else
        {
            On28.enabled = false;
            Off28.enabled = true;
        }
    }
    public void UpdateButtonIcon29()
    {
        if (muted == false)
        {
            On29.enabled = true;
            Off29.enabled = false;
        }
        else
        {
            On29.enabled = false;
            Off29.enabled = true;
        }
    }
    public void UpdateButtonIcon30()
    {
        if (muted == false)
        {
            On30.enabled = true;
            Off30.enabled = false;
        }
        else
        {
            On30.enabled = false;
            Off30.enabled = true;
        }
    }
    public void UpdateButtonIcon31()
    {
        if (muted == false)
        {
            On31.enabled = true;
            Off31.enabled = false;
        }
        else
        {
            On31.enabled = false;
            Off31.enabled = true;
        }
    }
    public void UpdateButtonIcon32()
    {
        if (muted == false)
        {
            On32.enabled = true;
            Off32.enabled = false;
        }
        else
        {
            On32.enabled = false;
            Off32.enabled = true;
        }
    }

    public void GetInputOnclickHandler()
    {
        // Debug.Log("Nom : "+InputNom.text);
        //string nom = InputNom.text;
        //Debug.Log("Prenom: " + InputPrenom.text);
        //string prenom = InputPrenom.text;
        Debug.Log("Num: " + num);
        //string num = InputNum.text;
        AddUser(num);

        float nbr = float.Parse(num);
        numtableSO.Value = nbr;
        
         

    }

    public void home()
    {
        SceneManager.LoadScene(1);
    }

    public void AddUser(string num)
    {
        // string nom, string prenom,
        WWWForm form = new WWWForm();
        //form.AddField("addNom", nom);
        //form.AddField("addPrenom", prenom);
        form.AddField("addNum", num);

        WWW www = new WWW(URL, form);
    }




}
