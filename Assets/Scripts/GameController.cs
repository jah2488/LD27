using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GUIStyle CustomDialog;
	public GUIStyle CustomMessage;

	bool DisplayDialog;
	bool DisplayMessage;
	string CurrentDialog;
	string CurrentMessage;

	int SecondsCollected = 0;


	public float LightningIntervals = 40f;
	float lightningTimer = 0f;

	void Update() {
		if(Input.GetKey(KeyCode.Return)) {
			DismissMessage();
			DismissDialog();
		}

		if(lightningTimer > 0.3f) {
			StopFlash();
		}
		if(lightningTimer < LightningIntervals) {
			lightningTimer += Time.deltaTime;
		} else {
			lightningTimer = 0;
			ScreenFlash();
		}

		if(SecondsCollected >= 10) {
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}

	void ScreenFlash() {
		GameObject.FindGameObjectWithTag("Light").light.intensity = 5.0f;
	}
	void StopFlash() {
		GameObject.FindGameObjectWithTag("Light").light.intensity = 0.01f;
	}

	void OnGUI() {
		if(DisplayDialog) {
			GUI.Box(displayBox(), CurrentDialog, CustomDialog);
		} else if(DisplayMessage) {
			GUI.Box(displayBox(), CurrentMessage, CustomMessage);
		}
		GUI.Box(new Rect(10,10,300,300), "You've collected " + SecondsCollected + " Seconds", CustomDialog);
	}

	public void PickedUpSecond(){
		SecondsCollected += 1;
	}

	public void UpdateDialog(string dialog) {
		CurrentDialog = "\"" + dialog + "\"\n\n [Return to Dismiss]";
		DisplayDialog = true;
	}

	public void UpdateMessage(string message) {
		CurrentMessage = message + "\n\n [Return to Dismiss]";
		DisplayMessage = true;
	}

	void DismissDialog()  { DisplayDialog = false; }
	void DismissMessage() { DisplayMessage = false; }


	Rect displayBox() {
		return new Rect(Screen.width * 0.2f, Screen.height * 0.8f, Screen.width * 0.6f, Screen.height * 0.1f);
	}
	static float LinearConversion (float oldValue, float oldMax, float OldMin, float NewMax, float NewMin)
	{
		return (((oldValue - OldMin) * (NewMax - NewMin)) / (oldMax - oldMax)) + NewMin;
	}
}
