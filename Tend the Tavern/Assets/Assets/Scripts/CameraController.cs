using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    //the camera and height and width of the camera
    [SerializeField] Camera mainCam;
    float camHeight;
    float camWidth;
    
    //what screen the player is on
    public enum location
    {
        Dishes,
        Bar,
        Stove,
        Tap
    }
    [SerializeField] location currentArea = location.Bar;

    //the mouse location
    [SerializeField] Vector2 mousePos;


    // Start is called before the first frame update
    void Start()
    {
        //Calculate the height and width of the camera
        camHeight = mainCam.orthographicSize;
        camWidth = camHeight * mainCam.aspect;

        //Get the mouse location
        UpdateMouse();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the mouse location
        UpdateMouse();

        //If mouse is clicked on the left side of the screen, turn left.
        if (Input.GetMouseButtonDown(0) && mousePos.x <= -8)
        {
            Debug.Log("Moved Left");
            MoveLeft();
        }

        //If the mouse is clicked on the right side of the screen, turn right
        else if (Input.GetMouseButtonDown(0) && mousePos.x >= 8)
        {
            Debug.Log("Moved Right");
            MoveRight();
        }
    }

    /// <summary>
    /// Updates the mouse location. Should be called every Update().
    /// </summary>
    public void UpdateMouse()
    {
        mousePos = Mouse.current.position.ReadValue();
        mousePos = mainCam.ScreenToWorldPoint(mousePos);
        mousePos.x -= mainCam.transform.position.x;
    }

    /// <summary>
    /// Moves the player one screen left.
    /// </summary>
    public void MoveLeft()
    {
        //Location to update the camera to
        Vector2 newLocation = mainCam.transform.position;

        //update the transform of the camera
        if (currentArea != location.Dishes)
        {
            newLocation.x -= 2 * camWidth;
        }
        //dishes is the special case due to layout
        else
        {
            newLocation.x += 6 * camWidth;
        }
        mainCam.transform.position = newLocation;

        //now update the enum
        switch (currentArea)
        {
            case location.Dishes:
                currentArea = location.Stove;
                break;

            case location.Tap:
                currentArea = location.Bar;
                break;

            case location.Stove:
                currentArea = location.Tap;
                break;

            case location.Bar:
            default:
                currentArea = location.Dishes;
                break;
        }
    }

    /// <summary>
    /// Moves the player one screen right
    /// </summary>
    public void MoveRight()
    {
        //Location to update the camera to
        Vector2 newLocation = mainCam.transform.position;

        //update the transform of the camera
        if (currentArea != location.Stove)
        {
            newLocation.x += 2 * camWidth;
        }
        //stove is the special case due to layout
        else
        {
            newLocation.x -= 6 * camWidth;
        }
        mainCam.transform.position = newLocation;

        //now update the enum
        switch (currentArea)
        {
            case location.Dishes:
                currentArea = location.Bar;
                break;

            case location.Tap:
                currentArea = location.Stove;
                break;

            case location.Stove:
                currentArea = location.Dishes;
                break;

            case location.Bar:
            default:
                currentArea = location.Tap;
                break;
        }
    }
}
