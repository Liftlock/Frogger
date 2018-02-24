
using UnityEngine;

public class CarController : MonoBehaviour {

	private float m_speed = 1.0f;
	public float m_minSpeed = 2.0f;
	public float m_maxSpeed = 2.0f;
	private Rigidbody2D m_rb;
	
	void Start() {
		m_rb = GetComponent<Rigidbody2D>();
		m_speed = Random.Range(m_minSpeed, m_maxSpeed);
	}
	
	void FixedUpdate() {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		
		m_rb.MovePosition(m_rb.position + forward * Time.fixedDeltaTime * m_speed);
	}



}
