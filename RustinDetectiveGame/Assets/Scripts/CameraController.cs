using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera selfCamera; // the camera we want to have display the stuff
    // Start is called before the first frame update
    void Start()
    {
        selfCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>()) // when the player runs into the camera
        {
            selfCamera.enabled = true; // make that camera active
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            selfCamera.enabled = false; // make camera not active when the player stops touching it
        }
    }
}
