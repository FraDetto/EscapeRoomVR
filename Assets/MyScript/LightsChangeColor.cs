using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsChangeColor : MonoBehaviour
{
    private GameObject puzzleLightsMangaer;
    // Start is called before the first frame update

    public Material OnMaterial;
    private Material OffMaterial;

    private void Start()
    {
        OffMaterial = GetComponent<MeshRenderer>().material;
    }

    public void setLightManager(GameObject lm)
    {
        puzzleLightsMangaer = lm;
    }

    public void lightOn()
    {
        GetComponent<MeshRenderer>().material = OnMaterial;
    }

    public void lightOff()
    {
        GetComponent<MeshRenderer>().material = OffMaterial;
    }
}
