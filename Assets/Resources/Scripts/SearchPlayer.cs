using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SearchPlayer : MonoBehaviour {
    
    [SerializeField]
    public GameObject target;
    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Update(){
        if(agent.pathStatus != NavMeshPathStatus.PathInvalid) {
            agent.destination = target.transform.position;
        }   
    }
}