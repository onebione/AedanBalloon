using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public PlayerController controller;
    public float speed = 10f;

    float horizontalMove = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;//left arrow -1, right arrow 1. 

    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
