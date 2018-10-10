using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDownBehavior : MonoBehaviour {
    public float speed;
    public float endY;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= endY)
        {
            //destroy the object after getting out of screen or something. 
            Destroy(gameObject);
        }
    }
}
