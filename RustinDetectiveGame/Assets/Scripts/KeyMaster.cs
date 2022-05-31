using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMaster : MonoBehaviour
{
    public bool ownKey; // to know if the player has the key or not
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
        // when we collide with the key, "collect it" and flip our bool to true
        if (collision.gameObject.CompareTag("Key"))
        {
            ownKey = true;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when we collide with the door, if we own key we "open" the door
        if (collision.gameObject.CompareTag("Door"))
        {
            if(ownKey == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
