#undef TESTAD
using System;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsService : Singleton<AdsService>
{
    private InterstitialAd interstitial;

    private void Start()
    {
        AdsService.GetInstance();
        MobileAds.Initialize(initStatus => { RequestInterstitial();});
    }

    private void RequestInterstitial()
    {
        Debug.Log("광고 시작");
        #if TESTAD
            Debug.Log("해햇");
            string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        #elif UNITY_ANDROID
            Debug.Log("광고 시작2");
            string adUnitId = "ca-app-pub-3115390690170379~8834966356";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
          // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void ShowAd()
    {
        if(PlayerInfo.Instance.GetIsAds() == false)
            return;

        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}
