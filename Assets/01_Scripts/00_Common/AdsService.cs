#undef TESTAD
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsService : Singleton<AdsService>
{

    private void Start()
    {
    }

    private void RequestInterstitial()
    {
        Debug.Log("광고 시작");
      
    }

    public void ShowAd()
    {
       
    }
}
