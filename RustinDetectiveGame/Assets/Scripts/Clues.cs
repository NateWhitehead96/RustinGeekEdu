using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // grant us access to using the text objects

public class Clues : MonoBehaviour
{
    public Text clueText;
    public GameObject promptInputDisplay; // a reference to the press E to invesitage
    public bool touchingClue; // know if the player is touching the clue or not so we can investigate it
    public string clueInfo; // the information about the clue

    public bool obtainedClue; // to know if we have gotten the clue from the clue
    // Start is called before the first frame update
    void Start()
    {
        clueText.gameObject.SetActive(false); // hide the display text
        promptInputDisplay.SetActive(false); // hide that too
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && touchingClue == true) // only when we are touching the clue and pressing E
        {
            clueText.gameObject.SetActive(true);
            clueText.text = clueInfo;
            if(obtainedClue == false) // only counts up if we haven't found the clue
            {
                FindObjectOfType<CluesFound>().found += 1; // make our found clues go up by 1
                obtainedClue = true; // now we have found the clue
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        promptInputDisplay.SetActive(true); // show the press E thing
        touchingClue = true; // set this bool true
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        promptInputDisplay.SetActive(false); // show the press E thing
        touchingClue = false; // set this bool true
        clueText.gameObject.SetActive(false);
    }
}
