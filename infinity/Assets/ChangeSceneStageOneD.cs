using UnityEngine;
using System.Collections;

public class ChangeSceneStageOneD : MonoBehaviour{

	void OnTriggerEnter(Collider co)
	{
		if (co.name == "Player")
			UnityEngine.SceneManagement.SceneManager.LoadScene ("first");
	}
}