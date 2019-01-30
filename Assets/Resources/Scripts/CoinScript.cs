using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {
    
    [SerializeField]
	private int havePoint;
    
    private GameObject player;
    private PlayerStatus script;
    
    void Start(){
        player = GameObject.Find ("ethen");
        script = player.GetComponent<PlayerStatus>();
    }
    
    void OnTriggerEnter (Collider other){
        
        if(other.gameObject.tag != "Player"){return;}
        
        Debug.Log("+" + havePoint + "ポイント");
        
        script.changeScore(havePoint);
        
        Destroy (this.gameObject);
            
    }
}
