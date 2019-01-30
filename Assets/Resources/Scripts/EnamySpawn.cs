using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamySpawn : MonoBehaviour {
    
    [SerializeField]
    public GameObject Enemy;

	// Use this for initialization
	void OnCollisionEnter (Collision collision) {
		if(collision.gameObject.tag == "Player"){
            Instantiate(Enemy, new Vector3(-72, 110, -100), Quaternion.identity);
        }
	}
}
