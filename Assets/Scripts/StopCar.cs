using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class StopCar : MonoBehaviour,IPointerDownHandler {

    public GameObject car;
    public CarJoyStick carmove;
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Stop")
        {
            car.GetComponent<Rigidbody>().velocity = Vector3.zero;
            carmove=car.GetComponent<CarJoyStick>();
            carmove.accelerate = 0f;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
