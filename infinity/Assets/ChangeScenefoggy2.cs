using UnityEngine;
using System.Collections;

public class ChangeScenefoggy2 : MonoBehaviour{
	
	void OnTriggerEnter(Collider co)
	{
		if (co.name == "Player")
			UnityEngine.SceneManagement.SceneManager.LoadScene ("foggy2");
	}
}