using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartHack : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    public static bool isHacking=false;
    public GameObject text;
    public GameObject button;
    public bool hackComplete;
    public static void Init()
    {
        isHacking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime && isHacking&& slider.value<1)
        {
            nextActionTime += period;
            slider.value += 0.01f;
            text.SetActive(false);
        }
        if(slider.value == 1)
        {
            isHacking = false;
            text.SetActive(true);
            hackComplete = true;
            button.SetActive(true);
        }
    }
}
