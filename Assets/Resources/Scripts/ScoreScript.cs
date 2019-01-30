using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    
    private GameObject player;
    private PlayerStatus script;
    
    private Text scoreText;
    
    void Start() {
        player = GameObject.Find ("ethen");
        script = player.GetComponent<PlayerStatus>();
        
        scoreText = GetComponentInChildren<Text> ();
    }

	void Update () {
        
        scoreText.text = "Score: " + script.getScore();
		
	}
}
