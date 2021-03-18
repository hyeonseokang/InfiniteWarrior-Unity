using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsService : Singleton<AdsService>
{
    private void Awake()
    {
        Advertisement.Initialize("4047168", true);
    }
    public void ShowAd()
    {
        Debug.Log("광고시작 : " + Advertisement.IsReady());
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }
    }
}
