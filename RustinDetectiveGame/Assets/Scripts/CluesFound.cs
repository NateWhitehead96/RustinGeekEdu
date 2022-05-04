using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CluesFound : MonoBehaviour
{
    public int found; // how many clues we have found
    public int numberOfClues; // how many clues are there to find
    public Text clueText; // so we can update our clues found text
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clueText.text = "Clues Found: " + found + " / " + numberOfClues; // this should print "Clues Found: 0 / 3"
    }
}
