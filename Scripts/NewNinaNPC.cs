using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ne2NinaNPC : MonoBehaviour
{
    void Update()
    {
        string activeCue = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("storyStep")).value;
        switch (activeCue)
        {
            case "0":
                {
                    break;
                }
            case "1":
                {
                    break;
                }
            case "2":
            {
                    break;
            }
        }
    }
}
