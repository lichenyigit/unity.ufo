using UnityEngine;
using UnityEngine.UI;

//金币控制器
public class GoldCoinController : MonoBehaviour {

	private GameController gameController;

	// Use this for initialization
	void Start () {
		GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");
		if (gameObject != null)
		{
			gameController = gameObject.GetComponent<GameController>();
		}
		else
		{
			Debug.Log("没有找到 'GameController' ");
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		Destroy(gameObject);
		gameController.addScore();
	}

}
