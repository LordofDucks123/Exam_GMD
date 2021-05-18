using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapComplete : MonoBehaviour
{

	public GameObject WholeLapTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	void OnTriggerEnter()
	{

		if (LapManager.SecondCount <= 9)
		{
			SecondDisplay.GetComponent<Text>().text = "0" + LapManager.SecondCount + ".";
		}
		else
		{
			SecondDisplay.GetComponent<Text>().text = "" + LapManager.SecondCount + ".";
		}

		if (LapManager.MinuteCount <= 9)
		{
			MinuteDisplay.GetComponent<Text>().text = "0" + LapManager.MinuteCount + ".";
		}
		else
		{
			MinuteDisplay.GetComponent<Text>().text = "" + LapManager.MinuteCount + ".";
		}

		MilliDisplay.GetComponent<Text>().text = "" + LapManager.MilliCount;

		LapManager.MinuteCount = 0;
		LapManager.SecondCount = 0;
		LapManager.MilliCount = 0;

		HalfLapTrig.SetActive(true);
		WholeLapTrig.SetActive(false);
	}

}