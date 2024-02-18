using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    [SerializeField] private SceneManager sceneManager;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public bool mouseDown = false;
    public bool click = false;
    public bool unclick = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sceneManager.worldPosition;

        // update mouse
        if (Input.GetMouseButtonDown(0) && !mouseDown)
        {
            spriteRenderer.color = Color.black;
            mouseDown = true;
            click = true;
        }
        else if (Input.GetMouseButtonUp(0) && mouseDown)
        {
            spriteRenderer.color = Color.white;
            mouseDown = false;
            unclick = true;
        }
        // reset pulse bools
        else
        {
            click = false;
            unclick = false;
        }

    }
}
