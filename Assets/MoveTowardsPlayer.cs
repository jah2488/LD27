using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour {

	public Transform Target;
	public float Speed = 20f;
	public float ApproachDistance = 10f;
	bool PlayerInSight;


	void Update() {
		if(PlayerInSight && Vector3.Distance(Target.position, transform.position) > ApproachDistance)
			transform.position += transform.forward * Speed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other) { PlayerInSight = true;  }
	void OnTriggerExit(Collider other)  { PlayerInSight = false; }
}
