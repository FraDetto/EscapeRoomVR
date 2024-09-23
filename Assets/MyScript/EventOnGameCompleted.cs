using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EventOnGameCompleted : MonoBehaviour
{
    public Transform doorRight;
    public Transform doorLeft;


    private void Start()
    {
        GameManagerLevel gml = GetComponent<GameManagerLevel>();
        gml.onGameCompleted += GameManagerLevel_OnGameCompleted;
    }

    private void GameManagerLevel_OnGameCompleted(object sender, EventArgs e)//chiamo quando completo puzzle pianeti
    {
        StartCoroutine("openDoorRightCabinet");
    }


    private IEnumerator openDoorRightCabinet()
    {
        for (float i = 0f; i <= 60f; i += 2f)
        {
            doorRight.localRotation = Quaternion.Euler(0f, i, 0f);
            yield return new WaitForSeconds(0f);
        }
        StartCoroutine("openDoorLeftCabinet");
    }

    private IEnumerator openDoorLeftCabinet()
    {
        for (float i = 0f; i <= 60f; i += 2f)
        {
            doorRight.localRotation = Quaternion.Euler(0f, -i, 0f);
            yield return new WaitForSeconds(0f);
        }

    }


}
