

using UnityEngine;

public class GamePlay : MonoBehaviour {

	public FSM m_FSM; 
	public void GameOver() {

		m_FSM.ChangeState(State.over);
	}

}
