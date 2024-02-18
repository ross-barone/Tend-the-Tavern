using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class InteractableAbstract : MonoBehaviour
{
    [SerializeField] MouseBehavior mouse;
    [SerializeField] private SceneManager sceneManager;

    /// <summary>
    /// While mouseover, will check for a click
    /// </summary>
    virtual protected void OnMouseOver()
    {
        if (mouse.click)
        {
            onClick();
        }
    }

    /// <summary>
    /// Called when interactable is clicked on
    /// </summary>
    abstract protected void onClick();
}
