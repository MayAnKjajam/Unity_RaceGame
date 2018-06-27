using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
	public Transform Player;
	public float speed=5f;
	public float maxspeed=5f;
	public bool move;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (move) {
			Vector3 temp = Player.transform.position;
			temp.x = temp.x - speed;
			this.transform.position = temp;
		} else {
		
		}
	}
}
