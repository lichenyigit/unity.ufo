using UnityEngine;

//UFO控制器
public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed;

	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate() {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(horizontal, vertical);
		rb.AddForce(movement * speed);
	}

	
}
