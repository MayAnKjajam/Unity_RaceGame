using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;
public class AdManager : MonoBehaviour {
    public static AdManager Instance { set; get; }
    public string BanerId= "ca - app - pub - 5277642435008955 / 5406365428", VideoId= "ca-app-pub-5277642435008955/5651700017";
    // Use this for initialization
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        Admob.Instance().initAdmob(BanerId, VideoId);//"ca - app - pub - 5277642435008955 / 5406365428", "ca-app-pub-5277642435008955/5651700017");
        Admob.Instance().loadInterstitial();
    

    }
    // Update is called once per frame
	void Update () {
		
	}
    public void ShowBaner()
    {
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 5);

    }
    public void ShowVideo()
    {
        
        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();

        }
    }
}
