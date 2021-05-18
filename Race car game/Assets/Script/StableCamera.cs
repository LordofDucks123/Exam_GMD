using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableCamera : MonoBehaviour
{
    public GameObject MyCar;
    public float myCarX;
    public float myCarY;
    public float myCarZ;

    // Update is called once per frame
    void Update()
    {
        myCarX = MyCar.transform.eulerAngles.x;
        myCarY = MyCar.transform.eulerAngles.y;
        myCarZ = MyCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(myCarX - myCarX, myCarY, myCarZ - myCarZ);

    }
}
