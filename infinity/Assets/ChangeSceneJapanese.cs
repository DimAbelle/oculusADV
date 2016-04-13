using UnityEngine;
using System.Collections;

public class ChangeSceneJapanese : MonoBehaviour{

	void OnTriggerEnter(Collider co)
	{
		if (co.name == "Player")
			UnityEngine.SceneManagement.SceneManager.LoadScene ("japanese house unity");
	}
}