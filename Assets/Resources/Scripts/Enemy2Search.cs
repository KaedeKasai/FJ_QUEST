using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2Search : MonoBehaviour {
    
    [SerializeField]
    private float speed;

    private GameObject enemy;
    private NavMeshAgent nav;
    
    void Start(){
        enemy = GameObject.Find ("Enemy2");
        nav = enemy.GetComponent<NavMeshAgent>();
    }
    
    
    void OnTriggerEnter (Collider other){
        
        if(other.gameObject.tag != "Player"){return;}
        
        nav.speed = speed;
    }
}