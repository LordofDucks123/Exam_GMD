using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWay : MonoBehaviour
{
	public GameObject FinnishLineTrig;
	public GameObject HalfWayTrig;

	void OnTriggerEnter()
	{
		FinnishLineTrig.SetActive(true);
		HalfWayTrig.SetActive(false);
	}
}
