using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerBehavior : MonoBehaviour {
    //use this script to control what goes on in a scene, programmatically. 
    //this script might end up only good for one particular scene. but that's probably ok. otherwise you would 
    //end up with too many layers. 
    public GameObject Obstacle;
    public float TimeBetweenObstacles;
    float FixedTimeBetweenObstacles;
    public float StartY;
    public float StartX;
    public float EndX; //randomly make an obstacle between two X's.  
	// Use this for initialization
	void Start () {
        //just remember it for later reference use. 
        FixedTimeBetweenObstacles = TimeBetweenObstacles;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Time Between Obstacle" + TimeBetweenObstacles);
        TimeBetweenObstacles -= Time.deltaTime;
        if (TimeBetweenObstacles <= 0)
        {
            //create an obstacle from time to time. 
            var x = Random.Range(StartX, EndX);
            var pos = new Vector3(x, StartY, -1);
            Instantiate(Obstacle, pos, Quaternion.identity);
            TimeBetweenObstacles = Random.Range(FixedTimeBetweenObstacles, FixedTimeBetweenObstacles + 2);
        }
    }
}
