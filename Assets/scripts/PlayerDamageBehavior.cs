using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageBehavior : MonoBehaviour {

    public GameObject deathPrefabParticleSystem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("try");
	}
    void Awake()
    {
        // add isTrigger
        var boxCollider = gameObject.GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
    }

    //dont get how this is triggered, since this is a script and not a object. 
    //maybe any script with "OnTriggerEnter" is activated when the parent gameObject collide with something. 
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("player damage behavior OnTriggerEnter");
        // If the entering collider is the player...
        if (other.gameObject.tag == "obstacles")
        {
            // ... the player is in range.
            Debug.Log("player touched obstacle");
            var pe = Instantiate(deathPrefabParticleSystem, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(pe, 4);
        }
    }
}
