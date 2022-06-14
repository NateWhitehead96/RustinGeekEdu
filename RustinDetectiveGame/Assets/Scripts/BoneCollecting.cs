using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollecting : MonoBehaviour
{
    public bool hasBone; // if we have the bone
    public GameObject boneDisplay; // a popup for when we "pickup" the bone
    public float timer; // to know when to hide the popup
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            boneDisplay.SetActive(false); // hide the "you picked up a bone" prompt after 2 seconds
        }
        timer -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "GarbageCan")
        {
            hasBone = true; // now we have the bone
            boneDisplay.SetActive(true);
            timer = 2;
        }
    }
}
