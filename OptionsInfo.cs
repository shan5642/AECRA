using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsInfo : MonoBehaviour
{
    public GameObject optionsInfo;
    void Update()
    {
        // Reverse the active state every time letter O is pressed
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Check whether it's active / inactive 
            bool isActive = optionsInfo.activeSelf;

            optionsInfo.SetActive(!isActive);
        }
    }
}
