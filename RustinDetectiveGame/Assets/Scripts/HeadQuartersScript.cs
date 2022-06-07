using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // this helps with changing scenes

public class HeadQuartersScript : MonoBehaviour
{
    public Text money;

    public GameObject[] cases; // an array that holds all of our potential cases
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cases.Length; i++) // loops through all the cases to hide them until we unlock them
        {
            cases[i].SetActive(false);
        }
        cases[0].SetActive(true); // first case, we want to always be active
        if(GameManager.instance.casesClosed > 0)
        {
            cases[1].SetActive(true);
        }
        if(GameManager.instance.casesClosed > 1)
        {
            cases[2].SetActive(true); // we've beaten the 2nd case, show case 3 button
        }
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "$ " + GameManager.instance.cash; // this should print "$ whatever cash we have"
    }

    public void OpenCase(int levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad); // the scenemanager will know what scene to open by whatever number we put as level to load
    }
}
