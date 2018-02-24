using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSplash : MonoBehaviour {

	public FSM m_FSM; 
	public float m_splashDelay = 3f;
	private float m_countDownTimer;

	void Start () {
		m_countDownTimer = m_splashDelay;
	}
	
	
	void Update () {
		if(m_countDownTimer <= 0) {
			m_countDownTimer = m_splashDelay;
			m_FSM.ChangeState(State.menu);
		} else {
			m_countDownTimer -= Time.deltaTime;
		}
	}
}
