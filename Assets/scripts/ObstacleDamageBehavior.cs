using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamageBehavior : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        // add isTrigger
        var boxCollider = gameObject.GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;

    }

    //dont get how this is triggered, since this is a script and not a object. 
    //maybe any script with "OnTriggerEnter" is activated when the parent gameObject collide with something. 
    void OnTriggerEnter2D(Collider2D other)
    {
        //does it make sense to have player stuff here? maybe this logic should be on the player side. 
        Debug.Log("obstacle damage behavior OnTriggerEnter");
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range.
            Debug.Log("player touched obstacle");
            
        }
    }
}
