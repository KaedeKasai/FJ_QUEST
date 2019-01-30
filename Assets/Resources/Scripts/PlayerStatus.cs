using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour {

	private int score = 0;
    
    public void changeScore (int addNum){
        score = score + addNum;
        Debug.Log("プレイヤーのスコアは" + score);
    }
    
    public int getScore(){
        return score;
    }
    
}

