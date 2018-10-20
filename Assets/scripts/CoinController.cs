using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    public GameObject collectedPrefabParticleSystem;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("coin controller OnTriggerEnter");
        // If the entering collider is the player...
        if (other.gameObject.tag == "Player")
        {
            // ... the player is in range.
            Debug.Log("player touched coin");
            var pe = Instantiate(collectedPrefabParticleSystem, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10), gameObject.transform.rotation);
            Destroy(pe, 0.5f);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -100);
            Destroy(gameObject, 2);
            ScoreManager.instance.OnCoinCollected();
        }
        else if (other.gameObject.tag == "obstacles")
        {            
            //this can happen when they are spawned in a way hat touches each other.
            Debug.Log("obstacles touched coin");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -100);
            Destroy(gameObject, .01f);
        }
    }
}
