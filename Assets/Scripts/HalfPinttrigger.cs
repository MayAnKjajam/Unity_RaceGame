using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPinttrigger : MonoBehaviour
{
    public GameObject LapComplete;
    public GameObject HalfLap;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            LapComplete.SetActive(true);
            HalfLap.SetActive(false);
        }
    }
}
