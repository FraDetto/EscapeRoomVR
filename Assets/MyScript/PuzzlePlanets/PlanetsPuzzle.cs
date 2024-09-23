using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlanetsPuzzle : MonoBehaviour
{

    private bool sunInPosition;//bool di check
    private bool earthInPosition;//bool di check
    private bool moonInPosition;//bool di check
    private bool puzzleCompleted;//bool di check

    private GameManagerLevel gml;


    void Start(){
        gml = FindObjectOfType<GameManagerLevel>();        
    }

    // Update is called once per frame
    void Update(){
        if(!puzzleCompleted)
            if (sunInPosition && earthInPosition && moonInPosition){ //controllo pianeti siano in posto corretto
                puzzleCompleted = true;//blocco check di completamento
                gml.puzzleCompleted(0);//comunico al gamemanager che ho completato 1 puzzle
            }
    }

    public void setSunInPosition()
    {
        sunInPosition = true;
    }

    public void setEarthInPosition()
    {
        earthInPosition = true;
    }

    public void setMoonInPosition()
    {
        moonInPosition = true;
    }

    public void setSunNotInPosition()
    {
        sunInPosition = false;
    }

    public void setEarthNotInPosition()
    {
        earthInPosition = false;
    }

    public void setMoonNotInPosition()
    {
        moonInPosition = false;
    }

}
