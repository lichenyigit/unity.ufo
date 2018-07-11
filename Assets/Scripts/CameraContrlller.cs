using UnityEngine;

//相机控制器
public class CameraContrlller : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start() {
		offset = transform.position - player.transform.position;
	}

	private void LateUpdate() {
		transform.position = offset + player.transform.position;
	}

}
