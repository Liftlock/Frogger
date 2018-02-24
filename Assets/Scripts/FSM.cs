using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum State {
	splash, 
	menu,
	play,
	over
}; 


public class FSM : MonoBehaviour {


	// Splash -> MainMenu -> GamePlay -> Game Win / Game Loose -> Main Menu 
	public GameObject[] m_goStates; 


	public State m_gameState = State.splash;
	
	void Start() {
		ChangeState(m_gameState);
	}


	public void ChangeState(State newState) {
		
		m_gameState = newState;

		//Disable all 
		for( int i = 0 ; i < m_goStates.Length; i++) {
			m_goStates[i].SetActive(false);
		}

		// enable the new state 
		m_goStates[(int)m_gameState].SetActive(true);
	}







}
