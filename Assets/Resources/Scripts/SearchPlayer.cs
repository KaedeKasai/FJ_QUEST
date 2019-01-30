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

//    // Update is called once per frame
//    void OnCollisionStay(Collision collision) {
//		if(collision.gameObject.tag == "Player"){
//            agent.destination = target.transform.position;
//        }
//	}
    
    void Update(){
        if(agent.pathStatus != NavMeshPathStatus.PathInvalid) {
            agent.destination = target.transform.position;
        }   
    }
}