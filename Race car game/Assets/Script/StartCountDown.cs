using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountDown : MonoBehaviour
{

	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	// wanna start the car, once countdown is complete. 
	public GameObject CarControls;
	public AudioSource InsaneAwesomeTrackMusic;

	// Only calling method, once game starts.
	void Start()
	{
		StartCoroutine(CountStart());
	}


	IEnumerator CountStart()
	{
		//Replace text "3" and call the text. 
		yield return new WaitForSeconds(0.5f);
		//Setting Text to three to begin with, just in case. 
		CountDown.GetComponent<Text>().text = "3";
		//Playing audio everytime the animation starts
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		GoAudio.Play();
		InsaneAwesomeTrackMusic.Play();
		LapTimer.SetActive(true);
		//Activate the car once countdown is complete. 
		CarControls.SetActive(true);

	}


}
