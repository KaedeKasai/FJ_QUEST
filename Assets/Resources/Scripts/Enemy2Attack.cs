using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Attack : MonoBehaviour {
    
    public GameObject item;
	private Animator anim;
	
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update (){
		if (Input.GetKey (KeyCode.V)) {
			anim.SetBool("Attack", true);
		} else {
            anim.SetBool("Attack", false);
        }
	}
    
    public void Dead() {
        
    GameObject.Instantiate(item, transform.position + Vector3.up, Quaternion.identity);
    
    Destroy(this.gameObject);
        
    }
}