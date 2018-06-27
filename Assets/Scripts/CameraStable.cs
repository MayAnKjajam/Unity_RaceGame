using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject car;
    public float carx,cary,carz;
	
	// Update is called once per frame
	void Update () {
        carx = car.transform.eulerAngles.x;
        cary = car.transform.eulerAngles.y;
        carz = car.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(carx - carx, cary, carz - carz);
	}
}
