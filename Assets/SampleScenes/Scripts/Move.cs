using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    
    void OnCollisionEnter(Collision col){
        
        if(col.gameObject.tag == "Player"){
            for(int i = 0; i <= 10; i++){
                this.transform.Translate(0.0f, 10.0f, 0.0f);
            }
                
        }
        
//        if(col.gameObject.name == "prop_powerCube"){
//            Destroy(col.gameObject);
//        }
        
    }
}
