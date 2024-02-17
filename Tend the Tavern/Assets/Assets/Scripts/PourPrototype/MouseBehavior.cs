using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    [SerializeField] private SceneManager sceneManager;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public bool clicking = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sceneManager.worldPosition;

        // update mouse
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer.color = Color.black;
            clicking = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            spriteRenderer.color = Color.white;
            clicking = false;
        }
    }
}
