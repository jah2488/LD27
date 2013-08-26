using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour {


	public GUIStyle Style;
	int stage = 0;
	string message = "Time for bed.";
	// Update is called once per frame
	void Update () {
	    if(stage == 1) {
			message = "I lost so much time today...";
		}
	    if(stage == 2) {
		    message = "At least things make sense while I sleep...";
		}
		if(stage == 4 || stage == 5) {
			message = "..... *ZZZZ* ....";
		}
		if(stage >= 6) {
			message = "...Wait, what time is it?...";
		}

		if(stage >= 8 && Input.anyKeyDown) {
			Application.LoadLevel(Application.loadedLevel + 1);
		} else if (Input.anyKeyDown) {
			stage += 1;
		}
	}

	void OnGUI() {
		GUI.Box(new Rect(10,10, Screen.width - 10, Screen.height - 10), message, Style);
	}
}
