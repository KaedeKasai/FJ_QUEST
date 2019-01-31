using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {
    
    private EnemyAttack enemyScript;

    
    void OnTriggerStay (Collider other){
        
        Debug.Log("ok_1");
        
        if(other.gameObject.tag != "Monster"){return;}
        
        Debug.Log("ok_2");
        
        if(Input.GetKey (KeyCode.Z)){
            
            Debug.Log("DEAD!!");
            
            enemyScript = other.GetComponent<EnemyAttack>();
                
            enemyScript.Dead();
            
            
        }
        
        
    }
}
