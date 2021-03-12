using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateManager : Singleton<VibrateManager>
{
    private bool isMute = false;
    public void PlayVibration()
    {
        if (isMute == true)
            return;

        Handheld.Vibrate();
    }

    public void SetMute(bool isMute)
    {
        this.isMute = isMute;
    }
}
