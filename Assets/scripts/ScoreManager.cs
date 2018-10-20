using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    //this script decides how many points for each coin collected
    public float coinValue;
    //when to update the score
    public Text ScoreText;
    float GameScore = 0;
	// Use this for initialization
	void Start () {
		
	}
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance !=this)
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCoinCollected()
    {
        GameScore = GameScore + 5;
        ScoreText.text = GameScore.ToString();
    }
}
