using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticleEffect : MonoBehaviour
{
    public ParticleSystem particle;
    public string nameOfTriggerObject; // string is a sentence or word, so we want this to know the name of the object
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == nameOfTriggerObject) // if the thing colliding is the trigger object
        {
            particle.Play(); // play particle effect
        }
    }
}
