using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class GameSystem : MonoBehaviour {
 
	//　スタートボタンを押したら実行する
	public void OnClick() {
		SceneManager.LoadScene (0);
	}
    
    public void end() {
		Application.Quit();
	}
}