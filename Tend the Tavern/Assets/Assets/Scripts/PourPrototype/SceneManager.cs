using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    protected Vector3 mousePos;
    public Vector3 worldPosition;
    public List<GameObject> interactables;
    public MouseBehavior cursor;
    public bool hideCursor;

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
}
