using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar : MonoBehaviour {

    public GameObject MArker, marker01, marker02, marker03, marker04, marker05, marker06;
    public GameObject marker07, marker08,marker09,marker10,marker11;
    public int markertraker;


    // Update is called once per frame
    void Update() {
        if (markertraker == 0)
        {
            MArker.transform.position = marker01.transform.position;
        }
        if (markertraker == 1)
        {
            MArker.transform.position = marker02.transform.position;
        }
        if (markertraker == 2)
        {
            MArker.transform.position = marker03.transform.position;
        }
        if (markertraker == 3)
        {
            MArker.transform.position = marker04.transform.position;
        }
        if (markertraker == 4)
        {
            MArker.transform.position = marker05.transform.position;
        }
        if (markertraker == 5)
        {
            MArker.transform.position = marker06.transform.position;
        }
        if (markertraker == 6)
        {
            MArker.transform.position = marker07.transform.position;
        }
        if (markertraker == 7)
        {
            MArker.transform.position = marker08.transform.position;
        }
        if (markertraker == 8)
        {
            MArker.transform.position = marker09.transform.position;
        }
        if (markertraker == 9)
        {
            MArker.transform.position = marker10.transform.position;
        }
        if (markertraker == 10)
        {
            MArker.transform.position = marker11.transform.position;
        }
    }

   IEnumerator OnTriggerEnter(Collider collision)
     {
        
        if(collision.tag=="DreamCar")
        {
       this.GetComponent<BoxCollider>() .enabled= false;
           
            markertraker += 1;
            if (markertraker == 11)
            {
                markertraker = 0;

            }
            yield return new WaitForSeconds(0.5f);
         this.GetComponent<BoxCollider>().enabled = true;
        }
     }
}

