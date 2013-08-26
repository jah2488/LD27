using UnityEngine;
using System.Collections;

public class RotateLight : MonoBehaviour {

	public float rotationAmount = 90.0f;

	void Update () {
		transform.Rotate(90, rotationAmount * Time.deltaTime, 0);
	}
}
