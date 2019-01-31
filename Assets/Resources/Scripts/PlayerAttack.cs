﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	private Animator anim;
    private GameObject player;
    private PlayerStatus script;
    private EnemyAttack enemyScript;
	
	void Start () {
		anim = GetComponent<Animator>();
        player = GameObject.Find ("ethen");
        script = player.GetComponent<PlayerStatus>();
	}
	
	void Update (){
		if (Input.GetKey (KeyCode.Z)) {
			anim.SetBool ("Attack", true);
		} else {
			anim.SetBool ("Attack", false);
		}
	}
    
    void OnTriggerStay (Collider other){
        
        if(other.gameObject.tag != "Monster"){return;}
        
        Debug.Log("ok_1");
        
        if(Input.GetKey (KeyCode.Z)){
            
            Debug.Log("DEAD!!");
            
            enemyScript = other.GetComponent<EnemyAttack>();
                
            enemyScript.Dead();
            
            
        }
        
        
    }
    
}
