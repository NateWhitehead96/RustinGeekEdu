using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspect : MonoBehaviour
{
    public GameObject chatBox;
    // Start is called before the first frame update
    void Start()
    {
        chatBox.SetActive(false); // hide the suspect text
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>()) // when the player collides with suspect
        {
            chatBox.SetActive(true); // show the text
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>()) // when the player collides with suspect
        {
            chatBox.SetActive(false); // hide the text
        }
    }
}
