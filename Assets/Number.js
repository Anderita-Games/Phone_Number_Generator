#pragma strict
var Call : GameObject;
var First : UnityEngine.UI.InputField;
var Numb : UnityEngine.UI.Text;
var Top : UnityEngine.UI.Text;
	
function Start () {
	Call.SetActive (false);
}

function Update () {

}

function Generate () {
	var number = Random.Range(0,10);
	var number2 = Random.Range(0,10);
	var number3 = Random.Range(0,10);
	var number4 = Random.Range(0,10);
	var number5 = Random.Range(0,10);
	var number6 = Random.Range(0,10);
	var number7 = Random.Range(0,10);
	Call.SetActive (true);
	Numb.text = "Number: " + "     -" + number + number2 + number3 + "-" + number4 + number5 + number6 + number7;
	Debug.Log("Number: " + First.text + "-" + number + number2 + number3 + "-" + number4 + number5 + number6 + number7);
	PlayerPrefs.SetString("Saved", First.text + number + number2 + number3 + number4 + number5 + number6 + number7);
}

function Calling () {
	Application.OpenURL( "tel://" + PlayerPrefs.GetString("Saved"));
	Debug.Log(PlayerPrefs.GetString("Saved"));
}

function Topic () {
	var topic = Random.Range(1,11);
	if (topic == 1) {
		Top.text = "Topic: " +  "Do you think Trump will win?";
	} 
	else if (topic == 2) {
		Top.text = "Topic: " + "How was your day?";
	}
	else if (topic == 3) {
		Top.text = "Topic: " + "Is your regrigerator running?";
	}
	else if (topic == 4) {
		Top.text = "Topic: " + "Soo the weather";
	}
	else if (topic == 5) {
		Top.text = "Topic: " + "How did you get this number?!?";
	}
	else if (topic == 6) {
		Top.text = "Topic: " + "Dinguses are spreading";
	}
	else if (topic == 7) {
		Top.text = "Topic: " + "What if we never met?";
	}
	else if (topic == 8) {
		Top.text = "Topic: " + "Where do you live?";
	}
	else if (topic == 9) {
		Top.text = "Topic: " + "What would you do with a million?";
	}
	else if (topic == 10) {
		Top.text = "Topic: " + "Bitcoin";
	}
}