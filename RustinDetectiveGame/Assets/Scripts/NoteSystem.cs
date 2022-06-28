using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSystem : MonoBehaviour
{
    public int notesCollected; // how man notes we have collected
    public GameObject button; // to let us hide and show the button that will toggle the final note
    public GameObject finalNote;
    public Text noteCounter;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        finalNote.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        noteCounter.text = "Notes: " + notesCollected + " / " + " 3"; // display how many notes we collected
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Note"))
        {
            notesCollected++;
            if(notesCollected == 3)
            {
                button.SetActive(true);
                FindObjectOfType<CluesFound>().found++; // we found a new clue
            }
            Destroy(collision.gameObject);
        }
    }

    public void ToggleNote()
    {
        if (finalNote.activeInHierarchy) // if the note is on the screen
        {
            finalNote.SetActive(false); // hide it
        }
        else
        {
            finalNote.SetActive(true);
        }
    }
}
