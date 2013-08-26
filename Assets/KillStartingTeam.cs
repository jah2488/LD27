using UnityEngine;
using System.Collections;

public class KillStartingTeam : MonoBehaviour {


	void OnTriggerEnter(Collider collider) {
		GameObject startTeam = GameObject.FindWithTag("StartTeam");
		Destroy(startTeam);
	}
}
