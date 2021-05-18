using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControllerClass : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject CarAIControl;


    void Start()
    {
        
        CarControl.GetComponent<CarUserControl>().enabled = true;
        CarAIControl.GetComponent<CarAIControl>().enabled = true;
    }


}
