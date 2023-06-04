using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFloorMaterial : MonoBehaviour
{
    public Material material;
    public GameObject Panel_floor_imgs;
    

    

    public void ChangeTexture(Texture texture)
    {
        material.mainTexture = texture;
    }

    public void ResetTexture(Texture texture)
    {
        material.mainTexture = texture;
        Panel_floor_imgs.SetActive(false);
    }

    public void Savetexture()
    {
        Panel_floor_imgs.SetActive(false);

    }
}

