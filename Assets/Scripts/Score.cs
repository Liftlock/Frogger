using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

	public static int m_score = 0;
	public Text m_scoreText; 

	void Update() {
		m_scoreText.text = m_score.ToString(); 
	}

}
