using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenFinalDoor : MonoBehaviour
{
    public Transform door;
    public Image finalText;

    public void openFinalDoor()//chiamo quando premo pulsante
    {
        StartCoroutine("openDoor");     
    }


    private IEnumerator openDoor()
    {

        for (float i = 0f; i <= 45f; i += 3f)
        {
            door.localRotation = Quaternion.Euler(0f, -i, 0f);
            yield return new WaitForSeconds(0f);
        }
        finalText.gameObject.SetActive(true);
    }
}
