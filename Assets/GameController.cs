using UnityEngine;
using UnityEngine.UI;

//游戏控制器
public class GameController : MonoBehaviour {

	public Text scoreText;
	public Text winText;
	public int score;

	public GameObject GoldCoins;

	// Use this for initialization
	void Start () {
		Debug.Log("GameController Start " + GameObject.FindGameObjectsWithTag("GlodCoin").Length);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void addScore() {
		score++;
		updateScore();
		if (GameObject.FindGameObjectsWithTag("GlodCoin").Length == 1) {
			winText.text = "congratulations";
		}
	}

	public void updateScore() {
		scoreText.text = "Score: " + score;
	}
}
