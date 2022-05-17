using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int cash; // how much money we have
    public int casesClosed; // how many cases we've beaten

    private void Awake()
    {
        if(instance != null) // we already have a game manager so destroy the one in the scene
        {
            Destroy(gameObject);
        }
        else // we dont have a game manager so make this one the only one
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
