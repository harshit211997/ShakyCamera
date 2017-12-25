using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public ShakyCamera cameraShake;
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			cameraShake.Activate ();
		}
	}
}
