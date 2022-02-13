using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public TMP_Text currentHealth;


    public PlayerMovement playerMovement;

    void Update()
    {
        currentHealth.text = "Health: " + playerMovement.Health;
    }
}
