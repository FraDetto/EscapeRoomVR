using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLevel : MonoBehaviour
{
    private bool [] puzzlesCompleted = new bool[2];

    public event EventHandler onGameCompleted;
    public event EventHandler onPlantesPuzzleCompleted;

    private void allPuzzlesCompleted()
    {
        onGameCompleted?.Invoke(this, EventArgs.Empty);//Chiamo questo per aprire cassetto quando puzzles sono completi
    }


    public void puzzleCompleted(int i)//quando un puzzle viene completato chiama questo metodo
    {
        puzzlesCompleted[i] = true;

        int k = 0;

        for(int j= 0; j < puzzlesCompleted.Length; j++){//verifico se ho completato tutti i puzzle
            if (puzzlesCompleted[j]){
                k++;
            }
            else
            {
                break;
            }
        }

        if (k == puzzlesCompleted.Length)
        {
            allPuzzlesCompleted();
        }
        else if (i == 0)
        {
            Debug.Log("INVOCO puzzlue 1 finito");
            onPlantesPuzzleCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

    public bool getPuzzleComplete(int i)//controllo se è stato completato un puzzle specifico
    {
        return puzzlesCompleted[i];
    }
}
