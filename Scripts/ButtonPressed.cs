using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    //[Header("A button Number")]
    //[SerializeField] private int number;
    public GameObject button;
    public static int pressedbuttons;
    public void DetectPressedButton(bool value)
    {
        DialogueManager.buttonPressed = value;
    }

    public static void AddToPressedButtons()
    {
        pressedbuttons += 1;
        //Debug.Log(pressedbuttons);
    }

    public static void Unfreeze()
    {
        ComputerTrigger.deskTopActive = false;
        VirusComputerTrigger.deskTopActive = false;
    }
    private void Update()
    {
        if(pressedbuttons ==9)
        {
            button.SetActive(true);
            pressedbuttons = 0;
        }
    }
}
