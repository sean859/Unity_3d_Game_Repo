using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{	
 public Text TimerText; 
 public bool playing;
 private float Timer;

 void Update () {

	// This code will edit a text so when you apply this code to it, it will turn any text in a minutes:seconds:miliseconds timer that counts up forever in real time

 	if(playing == true){
  
	  Timer += Time.deltaTime;
	  int minutes = Mathf.FloorToInt(Timer / 60f);
	  int seconds = Mathf.FloorToInt(Timer % 60f);
	  int milliseconds = Mathf.FloorToInt((Timer * 100f) % 100f);
	  TimerText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00") + ":" + milliseconds.ToString("00");
	}

  }

}