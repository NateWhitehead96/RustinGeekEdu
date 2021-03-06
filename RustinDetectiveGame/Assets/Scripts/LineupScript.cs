using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LineupScript : MonoBehaviour
{
    public Text selectedDisplay; // the message you see when selecting a suspect
    public string CorrectGuess; // what it will say when you get the right bad guy
    public string IncorrectGuess; // what it will say when we get the wrong bad guy
    public GameObject HQButton; // to hide and show button
    public GameObject LineupPanel;
    public CluesFound cluesFound; // help with resetting the found amount
    public Clues[] clues; // help reset the clue obtained bool
    // Start is called before the first frame update
    void Start()
    {
        HQButton.SetActive(false); // hide button
        //selectedDisplay.gameObject.SetActive(false); // hide the text
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CorrectSuspect() // this button function will be on the 1 criminal
    {
        if (cluesFound.found == cluesFound.numberOfClues)
        {
            selectedDisplay.gameObject.SetActive(true);
            selectedDisplay.text = CorrectGuess;
            HQButton.SetActive(true);
        }
    }
    public void WrongSuspect() // this button function will be on the other suspects
    {
        GameManager.instance.cash -= 50; // we lose 50 dollas
        selectedDisplay.gameObject.SetActive(true);
        selectedDisplay.text = IncorrectGuess;
        cluesFound.found = 0; // reset found clues
        for (int i = 0; i < clues.Length; i++)
        {
            clues[i].obtainedClue = false; // loop through all the clues and set them back to false;
        }
        StartCoroutine(CloseUI());
    }
    IEnumerator CloseUI()
    {
        yield return new WaitForSeconds(2);
        selectedDisplay.gameObject.SetActive(false);
        gameObject.SetActive(false);
        //LineupPanel.SetActive(false);
        //FindObjectOfType<PoliceChief>().LineUp.SetActive(false);
    }
    public void ReturnToHQ()
    {
        GameManager.instance.cash += 100; // we get 100 dollas
        GameManager.instance.casesClosed++; // cases closed goes up by 1
        SceneManager.LoadScene("HeadQuarters"); // load HQ
    }
}
