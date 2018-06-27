using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour {
    [SerializeField]
    public GameObject Red, Blue,Green;
    public int carimport;
	// Use this for initialization
	void Start () {
        carimport = GlobalCar.Cartype;
        if (carimport == 1)
        {
            Red.SetActive(true);
            Blue.SetActive(false);
            Green.SetActive(false);
        }
        if (carimport == 2)
        {
            Blue.SetActive(true);
            Red.SetActive(false);
            Green.SetActive(false);
        }
        if (carimport == 3)
        {
            Green.SetActive(true);
            Red.SetActive(false);
            Blue.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
