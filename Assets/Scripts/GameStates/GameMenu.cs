using UnityEngine;

public class GameMenu : MonoBehaviour {

	public FSM m_FSM; 
	public void PlayGame() {
		m_FSM.ChangeState(State.play);
	}

}
