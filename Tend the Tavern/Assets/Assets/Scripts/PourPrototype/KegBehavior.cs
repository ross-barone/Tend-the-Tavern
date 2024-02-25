using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KegBehavior : InteractableAbstract
{
    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void onClick()
    {
        Debug.Log(name + " has been clicked!");


        if (sceneManager.tray.contentNamed.Contains("cup"))
        {
            Debug.Log("I'm going to fill this cup!");
        }
    }
}
