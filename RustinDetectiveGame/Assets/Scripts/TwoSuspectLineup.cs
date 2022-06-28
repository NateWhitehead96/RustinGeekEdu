using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TwoSuspectLineup : MonoBehaviour
{
    public Text selectedDisplay; // the message you see when selecting a suspect
    public string CorrectGuess; // what it will say when you get the right bad guy
    public string IncorrectGuess; // what it will say when we get the wrong bad guy
    public GameObject HQButton; // to hide and show button
    public GameObject LineupPanel;
    public CluesFound cluesFound; // help with resetting the found amount
    public Clues[] clues; // help reset the clue obtained bool
    public int correctCriminals;
    public int guesses; // how many guess you get which is 2
    // Start is called before the first frame update
    void Start()
    {
        HQButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(guesses == 2)
        {
            if(correctCriminals == 2)
            {
                HQButton.SetActive(true);
            }
            else
            {
                cluesFound.found = 1; // reset found clues
                for (int i = 0; i < clues.Length; i++)
                {
                    clues[i].obtainedClue = false; // loop through all the clues and set them back to false;
                }
                guesses = 0;
                correctCriminals = 0;
                selectedDisplay.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
    public void ReturnToHQ()
    {
        GameManager.instance.cash += 100; // we get 100 dollas
        GameManager.instance.casesClosed++; // cases closed goes up by 1
        SceneManager.LoadScene("HeadQuarters"); // load HQ
    }
}
