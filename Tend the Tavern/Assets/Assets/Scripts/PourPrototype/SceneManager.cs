using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    protected Vector3 mousePos;
    public Vector3 worldPosition;
    public MouseBehavior cursor;
    public bool hideCursor;

    public TrayBehavior tray;
    public List<GameObject> interactables;

    public Camera mainCam;
    public camState currentState = camState.main;
    public enum camState
    {
        main, keg
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = !hideCursor;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
    }

    /// <summary>
    /// Pass clicked item to tray
    /// </summary>
    public void addToTray(GameObject obj)
    {
        tray.addItem(obj);
    }

    /// <summary>
    /// Swap camera to specified camState's location
    /// </summary>
    /// <param name="toSwap"></param>
    public void swapCams(camState toSwap)
    {
        switch (toSwap)
        {
            case camState.main:
                default:
                //Change location and size of camera
                mainCam.gameObject.transform.position = new Vector3(0, 0, -10);
                mainCam.orthographicSize = 5;

                //Resize cursor
                cursor.transform.localScale = new Vector3(0.71f, 0.71f, 1);
                break;

            case camState.keg:
                //Change location and size of camera
                mainCam.gameObject.transform.position = new Vector3(2.18f, -1.79f, -10);
                mainCam.orthographicSize = 2.75f;

                //Resize cursor
                cursor.transform.localScale = new Vector3(0.39f, 0.39f, 1);
                break;
        }
    }

    /// <summary>
    /// Swap camera back to main position
    /// </summary>
    public void swapCams()
    {
        swapCams(camState.main);
    }
}
