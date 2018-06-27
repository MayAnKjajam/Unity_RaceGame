using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CARSounds : MonoBehaviour {
    public AudioClip lowAccelClip;
    public AudioClip highAccelClip;
    public AudioSource source;
    private CarJoyStick car;
    private Car car1;
    // Use this for initialization
    void Start () {
       // car = GetComponent<CarJoyStick>();
        car1 = GetComponent<Car>();
        source= gameObject.AddComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (car1.aceleration > 0.1f || car1.aceleration < 0.1f)
        {
            AudioSource.PlayClipAtPoint(highAccelClip, this.transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(lowAccelClip, this.transform.position);
        }
	}
}
