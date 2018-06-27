using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour {
	public Transform target;
	public float speedx, speedy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = target.transform.position;
		if(target.transform.position.x>=temp.x){
			Vector3 temp2 = this.transform.position;
			temp2.x -= speedx;
			temp2.y -= speedy;
			this.transform.position = temp2;

		}
}
}	