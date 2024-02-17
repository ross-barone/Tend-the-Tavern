using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayBehavior : InteractableAbstract
{
    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void onClick()
    {
        Debug.Log(name + " has been clicked!");
    }
}
