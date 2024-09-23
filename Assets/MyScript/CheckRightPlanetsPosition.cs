using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckRightPlanetsPosition : MonoBehaviour
{
    public int idSocket; //id univoco per socket: SunSocket=0, EarthSocket=2, Moon=8
    private PlanetsPuzzle planetsPuzzleManager;

    private void Start()
    {
        planetsPuzzleManager = FindObjectOfType<PlanetsPuzzle>();
    }

    public void checkPlanetPosition(SelectEnterEventArgs args)//quando inserisco i pianeti nelle socket controllo che pianeta giusto sia in socket giusto
    {//chiamato onselectEnter
        if (idSocket == 0 && args.interactableObject.transform.gameObject.tag.Equals("Sun")){
            planetsPuzzleManager.setSunInPosition();
        }else if(idSocket == 3 && args.interactableObject.transform.gameObject.tag.Equals("Earth")){
            planetsPuzzleManager.setEarthInPosition();
        }else if (idSocket == 8 && args.interactableObject.transform.gameObject.tag.Equals("Moon")){
            planetsPuzzleManager.setMoonInPosition();
        }
    }

    public void disableCheckPlanetOnExit(){// chiamato on selectOnExit
        
        if (idSocket == 0)
        {
            planetsPuzzleManager.setSunNotInPosition();
        }
        else if (idSocket == 3)
        {
            planetsPuzzleManager.setEarthNotInPosition();
        }
        else
        {
            planetsPuzzleManager.setMoonNotInPosition();
        }
    }

}
