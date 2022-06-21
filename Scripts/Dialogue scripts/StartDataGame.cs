using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDataGame : MonoBehaviour
{
    [Header("DeskTopPanel")]
    [SerializeField] private GameObject deskTopPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        deskTopPanel.SetActive(true);
        ComputerTrigger.deskTopActive = true;
    }
}
