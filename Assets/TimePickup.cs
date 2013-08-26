using UnityEngine;
using System.Collections;

public class TimePickup : MonoBehaviour {

	public GameController gc;

	void Update(){
		transform.Rotate(50f * Time.deltaTime, 20f * Time.deltaTime, 0);
	}
	void OnTriggerEnter(Collider collider) {
		gc.PickedUpSecond();
		Destroy(this.gameObject);
	}
}
