using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    private LightPuzzleManager puzzleLightsMangaer;

    public int id; // setto id per ogni luce in modo da fare check quando colpite

    void Start()
    {
        puzzleLightsMangaer = FindObjectOfType<LightPuzzleManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (puzzleLightsMangaer != null)
        {
            if (!puzzleLightsMangaer.getSequenceInAction())
            {
                if (other.gameObject.tag.Equals("Dart"))
                {
                    puzzleLightsMangaer.checkLightHit(id);
                }
            }
        }
            
    }

}
