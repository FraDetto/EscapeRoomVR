using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOff_TV_UI : MonoBehaviour
{
    private GameManagerLevel gml;
    private LightPuzzleManager puzzleLightsMangaer;
    private bool isShowing;

    public Image messageNoGun;
    public Image messageGun;

    public GameObject TriggerAreaToLightSequence;

    private void Start()
    {
        puzzleLightsMangaer = FindObjectOfType<LightPuzzleManager>();
        gml = FindObjectOfType<GameManagerLevel>();
    }

    public void OnMessage()
    {
        if (!isShowing)
        {
            if (gml.getPuzzleComplete(0))
            {
                messageGun.gameObject.SetActive(true);
                isShowing = true;
                TriggerAreaToLightSequence.gameObject.SetActive(true);
            }
            else
            {
                StartCoroutine("screenOtherText");
            }
        }
        else//se non c'è piu la sequenza di luci in corso e non è attivo il trigger lo faccio riapparire
        {
            if(!TriggerAreaToLightSequence.activeSelf && !puzzleLightsMangaer.getSequenceInAction())
                TriggerAreaToLightSequence.gameObject.SetActive(true);
        }
        
    }

    private IEnumerator screenOtherText()
    {
        isShowing = true;
        messageNoGun.gameObject.SetActive(true);
        yield return new WaitForSeconds(20f);
        isShowing = false;

    }

}
