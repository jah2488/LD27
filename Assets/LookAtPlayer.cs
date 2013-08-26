using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	public Transform target;

	bool PlayerInSight;

	void Update() {
		if(PlayerInSight) {
			transform.LookAt(target);

			if(GetComponent("audio")) {
				if(!audio.isPlaying) {
					audio.enabled = true;
					audio.Play();
				}
			}


		} else {
			if(GetComponent("audio")){
				audio.enabled = false;
				audio.Stop();
			}

		}
	}

	void OnTriggerEnter(Collider other) { PlayerInSight = true;  }
	void OnTriggerExit(Collider other)  { PlayerInSight = false; }
}
