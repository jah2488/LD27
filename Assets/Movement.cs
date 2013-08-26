using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float rotationSpeed = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("q")){
			Debug.Log("calleddd");
			transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
		} else if (Input.GetKey("e")) {
			transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
		}

	}
}
