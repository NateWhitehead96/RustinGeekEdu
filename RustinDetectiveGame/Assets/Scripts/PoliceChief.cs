using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceChief : MonoBehaviour
{
    public GameObject PoliceChatBox; // the text on screen the police chief says
    // Start is called before the first frame update
    void Start()
    {
        PoliceChatBox.SetActive(false); // make the text invisible from the start of the game
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>()) // when the player collides with police
        {
            PoliceChatBox.SetActive(true); // show the police text
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>()) // when the player collides with police
        {
            PoliceChatBox.SetActive(false); // hide the police text
        }
    }
}
