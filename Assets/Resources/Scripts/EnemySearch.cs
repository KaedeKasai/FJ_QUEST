using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySearch : MonoBehaviour {
    
    [SerializeField]
    private float speed;

    private GameObject enemy;
    private NavMeshAgent nav;
    
    void Start(){
        enemy = GameObject.Find ("Enemy1");
        nav = enemy.GetComponent<NavMeshAgent>();
    }
    
    
    void OnTriggerEnter (Collider other){
        
        if(other.gameObject.tag != "Player"){return;}
        
        nav.speed = speed;
    }
}
