using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoliceChief : MonoBehaviour
{
    public GameObject PoliceChatBox; // the text on screen the police chief says
    public string nextDialogue; // the dialogue for when we've collected all 3 clues
    public Text chat;
    public GameObject LineUp;
    // Start is called before the first frame update
    void Start()
    {
        PoliceChatBox.SetActive(false); // make the text invisible from the start of the game
        //LineUp = FindObjectOfType<LineupScript>().gameObject; // make sure everyone has access to this object
        LineUp.SetActive(false); // hide on start
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
            if(FindObjectOfType<CluesFound>().found == FindObjectOfType<CluesFound>().numberOfClues)
            {
                chat.text = nextDialogue; // make sure they say something else
                LineUp.SetActive(true); // show the lineup
            }
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
