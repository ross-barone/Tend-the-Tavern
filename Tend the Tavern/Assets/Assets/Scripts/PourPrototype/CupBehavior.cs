using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupBehavior : InteractableAbstract
{
    [SerializeField] private bool onTray = false;
    private Vector3 trayPosition = new Vector3(0.94f, -2.97f);

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void onClick()
    {
        //When clicked for the first time, cup moves to tray.
        if (!onTray)
        {
            onTray = true;
            transform.position = trayPosition;
        }
        
        Debug.Log(name + " has been clicked!");
    }
}
