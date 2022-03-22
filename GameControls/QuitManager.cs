using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            ExitGame();
        }
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
