using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class triggerToStartLightSequence : MonoBehaviour
{
    private LightPuzzleManager puzzleLightsMangaer;

    void Start()
    {
        puzzleLightsMangaer = FindObjectOfType<LightPuzzleManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Dart"))
        {
            puzzleLightsMangaer.invokeStartSequenceLights();
            this.gameObject.SetActive(false);
        }
    }
        
}
