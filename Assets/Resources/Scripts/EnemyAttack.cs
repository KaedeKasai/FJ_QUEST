using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    
	private Animator anim;
	
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update (){
		if (Input.GetKey (KeyCode.X)) {
			anim.SetBool("Attack", true);
		} else {
            anim.SetBool("Attack", false);
        }
	}
}