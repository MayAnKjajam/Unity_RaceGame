using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapTimeManager : MonoBehaviour {
    public static int Minutecount;
    public static int Secondscount;
    public static float milliseconds;
    public GameObject Minute, seconds;

    public static float RawTime;

    void Awake()
    {       PlayerPrefs.SetInt("min", 0);
            PlayerPrefs.SetInt("sec",0);
        Minutecount = PlayerPrefs.GetInt("min", Minutecount);
        Secondscount = PlayerPrefs.GetInt("sec", Secondscount);


    }
void Start() {

    }

    // Update is called once per frame
    void Update() {

        RawTime += Time.deltaTime;
        milliseconds += Time.deltaTime * 10;
        
        if (milliseconds >= 10)
        {
            milliseconds = 0;
            Secondscount += 1;
        }
        if (Secondscount <= 9)
        {
            seconds.GetComponent<Text>().text = "0" + Secondscount ;
        } else
        {
            seconds.GetComponent<Text>().text = "" + Secondscount ;
        }
        if (Secondscount >= 60)
        {
            Secondscount = 0;
            Minutecount += 1;
        }
        if (Minutecount <= 9)
        {
            Minute.GetComponent<Text>().text = "0" + Minutecount + ":";
        }
        else
        {
            Minute.GetComponent<Text>().text = "" + Minutecount+ ":";
        }

    }
}
