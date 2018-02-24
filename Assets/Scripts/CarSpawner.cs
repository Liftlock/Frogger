using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float m_spawnDelay = 0.3f;
	public GameObject m_carPrefab;
	public Transform m_carContainer; 
	public Transform[] m_spawnPoints;

	// Attached to Spawn Manager 
	// Spawners located at:  -9, 3  | 9, 1 | -9, -1 | 9, -3


	private float m_countDownTimer;

	void Start() {
		m_countDownTimer = m_spawnDelay;
	}

	void Update() {
		if(m_countDownTimer <= 0) {
			SpawnCar();
			m_countDownTimer = m_spawnDelay;
		} else {
			m_countDownTimer -= Time.deltaTime;
		}
	}

	private void SpawnCar() {
		int randomSpawn = Random.Range(0, m_spawnPoints.Length);
		Transform spawnPoint = m_spawnPoints[randomSpawn];

		GameObject tmpCar = Instantiate(m_carPrefab, spawnPoint.position, spawnPoint.rotation);
		tmpCar.name = "Car";
		tmpCar.transform.parent = m_carContainer.transform;

	}

}
