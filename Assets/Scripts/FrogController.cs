using UnityEngine;

public class FrogController : MonoBehaviour {

	public GamePlay m_GamePlayState; 

	private Rigidbody2D m_rb; 
	private Vector3 m_startPosition; 

	// Boundries
	// top 4 | bottom -4 | left -7 | right 7 

	void Start() {
		m_rb = GetComponent<Rigidbody2D>();
		m_startPosition = transform.position;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)) {
			if(transform.position.x < 7) {
				m_rb.MovePosition(m_rb.position + Vector2.right);
			}
		}	
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			if(transform.position.x > -7) {
				m_rb.MovePosition(m_rb.position + Vector2.left);
			}
		}	
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			if(transform.position.y < 4) {
				m_rb.MovePosition(m_rb.position + Vector2.up);
			}
		}	
		if(Input.GetKeyDown(KeyCode.DownArrow)) {
			if(transform.position.y > -4) {
				m_rb.MovePosition(m_rb.position + Vector2.down);
			}
		}	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy"){
			Debug.Log("Ouch! ");
			Score.m_score = 0;
			m_GamePlayState.GameOver();
		}

		if (other.tag == "Goal") {
			Score.m_score += 100;
			ResetPlayer();
		}
	} 


	private void ResetPlayer() {

		transform.position = m_startPosition;
	}


}
