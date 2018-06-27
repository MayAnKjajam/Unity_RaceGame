using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CarMoveButtons : MonoBehaviour,IPointerUpHandler,IPointerDownHandler {
    public CarJoyStick car;


    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Accelerate")
        {
            car.Accelerate = true;
            car.Deaccelerate = false;
        }
        if (gameObject.name == "DEAccelelraate")
        {
            car.Accelerate = false;
            car.Deaccelerate = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (gameObject.name == "Accelerate")
        {
            car.Accelerate = false;
        }
        if (gameObject.name == "DEAccelelraate")
        {
            car.Deaccelerate = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
