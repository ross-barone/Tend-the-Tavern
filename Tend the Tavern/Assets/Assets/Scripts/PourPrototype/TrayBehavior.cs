using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayBehavior : InteractableAbstract
{
    [SerializeField] private List<GameObject> contents;
    [SerializeField] public List<string> contentNamed;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnClick()
    {
        Debug.Log(name + " has been clicked!");
    }

    public void addItem(GameObject obj)
    {
        contents.Add(obj);
        contentNamed.Add(obj.name);
        Debug.Log(obj.name + " has been added to tray!");
    }
}
