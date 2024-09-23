using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class LightPuzzleManager : MonoBehaviour
{
    private GameManagerLevel gml;
    private bool sequenceInAction;
    private bool puzzleCompleted;
    private int countRightLights=0;

    public GameObject[] lights;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<LightsChangeColor>().setLightManager(this.transform.gameObject);//setto il manager per le lights
        }

        gml = FindObjectOfType<GameManagerLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleCompleted)//sequenza corretta
        {
            gml.puzzleCompleted(1);//completato puzzle luci
        }
    }

    public void invokeStartSequenceLights()//chiamo quando entro nella zona con il personaggio
    {
        StartCoroutine("startLightSequence");
    }

    private IEnumerator startLightSequence()
    {
        sequenceInAction = true;
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].GetComponent<LightsChangeColor>().lightOn();
                yield return new WaitForSeconds(2f);
                lights[i].GetComponent<LightsChangeColor>().lightOff();
            }
        sequenceInAction = false;
    }

    public void checkLightHit(int id)
    {
        if (id == countRightLights)
        {
            Debug.Log("PRESA UNA MELA " +  countRightLights);
            lights[id].GetComponent<LightsChangeColor>().lightOn();
            countRightLights++;
            if (countRightLights == lights.Length)
            {
                puzzleCompleted = true;
            }
        }
        else
        {
            countRightLights = 0;
            resetLights();
        }
    }

    public bool getSequenceInAction()
    {
        return sequenceInAction;
    }

    public void resetLights()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<LightsChangeColor>().lightOff();//setto il colore delle luci di nuovo a rosso
        }
    }
}

