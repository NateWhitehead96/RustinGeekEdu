using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnclePayout : MonoBehaviour
{
    public Suspect uncle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<KeyMaster>())
        {
            if(collision.gameObject.GetComponent<KeyMaster>().ownKey == true)
            {
                uncle.chatBox.GetComponent<Text>().text = "Oh great you found my key! Here have an oreo and $10 as payment!";
                GameManager.instance.cash += 10;
                //GetComponent<CircleCollider2D>().enabled = false; // can no longer interact with the uncle
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<KeyMaster>())
            GetComponent<CircleCollider2D>().enabled = false;
    }
}
