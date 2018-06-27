using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3.5f);
        Destroy(this.gameObject);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(DestroyObject());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
