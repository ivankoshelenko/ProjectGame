using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinaAwake : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [Header("Trigger")]
    [SerializeField] private GameObject trigger;
    [Header("Game Trigger")]
    [SerializeField] private GameObject gameTrigger;

    public static bool gamePlayed = false;
    // Update is called once per frame

 
    public static void SetGamePlayed()
    {
        gamePlayed = true;
    }
    void Update()
    {
        string activeCue = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("storyStep")).value;
        if (gamePlayed)
        {
            gameTrigger.SetActive(false);
            trigger.SetActive(false);
            NinaContinue.canCont = true;
        }
        else
        switch(activeCue)
        {
            case "0":
                visualCue.SetActive(false);
                break;
            case "1":
                visualCue.SetActive(true);
                break;
            case "2":
                if (!gamePlayed)
                {
                    trigger.SetActive(false);
                    gameTrigger.SetActive(true);                   
                }
                else
                {                  
                    gameTrigger.SetActive(false);
                    trigger.SetActive(false);
                    NinaContinue.canCont = true;
                        visualCue.SetActive(true);
                }
                break;
            //case "3":
            //    gamePlayed = false;
            //    contTrigger.SetActive(false);
            //    break;

        }
    }
}
