using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public TMP_Text currentHealth;

    public GameObject CompletedLevelUI;
    public GameObject GameFailedUI;


    public PlayerScript playerScript;

    void Update()
    {
        currentHealth.text = "Health: " + playerScript.Health;

        if (CompletedLevelUI.activeSelf || GameFailedUI.activeSelf)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        CompletedLevelUI.SetActive(true);
    }

    public void GameFailed()
    {
        GameFailedUI.SetActive(true);
    }
}
