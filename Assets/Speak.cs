using UnityEngine;
using System.Collections;

public class Speak : MonoBehaviour {

	public string Greeting = "Traveler, you must help us. Find the lost seconds. 10 there were. There is no time, there is actually less and less it seems.";
	public string Farewell = "Be swift. There is less in the desert than you imagine there to be.\t";

	public GameController GameController;
	bool entered;

	void Start() {
	}


	void OnTriggerEnter(Component other) {
		if(other.collider.tag == "Player") {
			GameController.UpdateDialog(Greeting);
		}
	}

	void OnTriggerExit(Component other) {
		if(other.collider.tag == "Player") {
		GameController.UpdateDialog(Farewell);
		}
	}
}
