using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{

	public GameObject NormalCam;
	public GameObject FarCam;
	public GameObject FirstPersonCam;
	public int CamMode;

	void Update()
	{
		//Constanstly checking if Viewmode is clicked
		if (Input.GetButtonDown("View"))
		{
			if (CamMode == 2)
			{
				CamMode = 0;
			}
			else
			{
				CamMode += 1;
			}
		// stop the execution until some certain condition is met and continues from where it had left off.
			StartCoroutine(ModeChange());
		}
	}

	IEnumerator ModeChange()
	{
		yield return new WaitForSeconds(0.01f);
		if (CamMode == 0)
		{
		//The new Camera is enabled first to avoid a split second of black screen.
			NormalCam.SetActive(true);
			FirstPersonCam.SetActive(false);
		//No need to set far cam bec no possible way we get to 0 bec mode nr 2 means FP cam is enabled.
		}
		if (CamMode == 1)
		{
			FarCam.SetActive(true);
			NormalCam.SetActive(false);
		}
		if (CamMode == 2)
		{
			FirstPersonCam.SetActive(true);
			FarCam.SetActive(false);
		}

	}
}
