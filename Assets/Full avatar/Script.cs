using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Experimental.Rendering;
using CrazyMinnow.SALSA;

public class Script : MonoBehaviour
{
    public GameObject newHead;
    public string fbxPath="Assets/Duplicate.fbx";
    public Salsa salsa;
    public SkinnedMeshRenderer skinnedMeshRenderer;


    void Start()
    { 
        salsa = GetComponent<Salsa>();
        if (this.gameObject.name=="Ch31_nonPBR"){
            GameObject head = GameObject.Find("mixamorig9:Hips/mixamorig9:Spine/mixamorig9:Spine1/mixamorig9:Spine2/mixamorig9:Neck/mixamorig9:Head");
        GameObject currentHead = GameObject.Find("Ch31_Body");
        GameObject currentHead1 = GameObject.Find("Ch31_Hair");
        GameObject currentHead2 = GameObject.Find("Ch31_Eyelashes");
           
        GameObject newHeadInstance = Instantiate(newHead);
            //newHeadInstance.transform.parent = currentHead.transform.parent;
            newHeadInstance.transform.SetParent(head.transform);
        newHeadInstance.transform.localPosition = currentHead.transform.localPosition+new Vector3(0, 0.055F, 0);
        newHeadInstance.transform.localRotation = currentHead.transform.localRotation;

            
            Destroy(currentHead);
        Destroy(currentHead2);
        Destroy(currentHead1);
            
        }
        else{
        

        /*GameObject currentHead = transform.Find("Boy_01_Meshes/Boy01_Hair_Geo").gameObject;
        GameObject currentHead1 = transform.Find("Boy_01_Meshes/Boy01_Head_Geo").gameObject;
        GameObject currentHead2 = transform.Find("Boy_01_Meshes/Boy01_Scarf_Geo").gameObject;
        GameObject newHeadInstance = Instantiate(newHead);
        newHeadInstance.transform.parent = currentHead1.transform.parent;
        newHeadInstance.transform.localPosition = currentHead1.transform.localPosition+new Vector3(0,1.4F,0);
        newHeadInstance.transform.localRotation = currentHead1.transform.localRotation;
        Destroy(currentHead);
        Destroy(currentHead2);
        Destroy(currentHead1);*/

        }
       
    
        
        
         
    }

    private void Update()
    {
        //Debug.Log(salsa.IsSALSAing);
        Debug.Log(salsa.visemes[0].expData);
    }


}
        
        
    

