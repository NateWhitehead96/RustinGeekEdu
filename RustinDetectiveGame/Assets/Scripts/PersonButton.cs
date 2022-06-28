using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonButton : MonoBehaviour
{
    public Button self;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<TwoSuspectLineup>().correctCriminals == 0)
            self.interactable = true;
    }
    public void CorrectSuspect()
    {
        FindObjectOfType<TwoSuspectLineup>().guesses++;
        FindObjectOfType<TwoSuspectLineup>().correctCriminals++; // increase this
        self.interactable = false;
    }

    public void WrongSuspect()
    {
        FindObjectOfType<TwoSuspectLineup>().guesses++;
        self.interactable = false;
    }
}
