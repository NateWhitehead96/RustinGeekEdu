using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DogScript : MonoBehaviour
{
    public PlayableDirector director; // this is the animation to move the dog
    public Camera[] sceneCameras;
    public Camera dogCamera;
    bool cutscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(director.state != PlayState.Playing && cutscene == true) // if the cut scene is over
        {
            dogCamera.enabled = false; // disable dog cam
            sceneCameras[0].enabled = true; // enable main floor cam
            cutscene = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BoneCollecting>() && collision.gameObject.GetComponent<BoneCollecting>().hasBone == true)
        {
            for (int i = 0; i < sceneCameras.Length; i++) // loop through all of the scene cameras to shut them off
            {
                sceneCameras[i].enabled = false;
                dogCamera.enabled = true;
                director.Play(); // play the "cutscene"
                cutscene = true;
                GetComponent<CircleCollider2D>().enabled = false; // disable collider so it stops playing the animation
            }
        }
    }
}
