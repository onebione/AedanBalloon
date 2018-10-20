using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

    public GameObject Coin;
    public float TimeBetweenGenerating;
    float FixedTimeBetweenGenerating;
    public float StartY;
    public float StartX;
    public float EndX;
    //randomly make coin between two X's.  
    // Use this for initialization
    void Start()
    {
        //just remember it for later reference use. 
        FixedTimeBetweenGenerating = TimeBetweenGenerating;
    }

    // Update is called once per frame
    void Update()
    {
        TimeBetweenGenerating -= Time.deltaTime;
        if (TimeBetweenGenerating <= 0)
        {
            //create a coin from time to time. 
            var x = Random.Range(StartX, EndX);
            var pos = new Vector3(x, StartY, -1);
            Instantiate(Coin, pos, Quaternion.identity);
            TimeBetweenGenerating = Random.Range(FixedTimeBetweenGenerating, FixedTimeBetweenGenerating + 2); 
        }
    }
}
