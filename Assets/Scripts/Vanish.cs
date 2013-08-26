using UnityEngine;
using System.Collections;

public class Vanish : MonoBehaviour {


	void OnCollisionEnter(Collision collision) {
		if(collision.relativeVelocity.magnitude > 0) {
			if(!audio.isPlaying)
				audio.Play();
		}
		Destroy(gameObject, 3f);
	}

	void OnTriggerEnter(Collider collision) {

	}

}
