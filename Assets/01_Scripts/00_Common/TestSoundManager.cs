using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSoundManager : MonoBehaviour
{
    private void Start()
    {
        SoundManager.Instance.PlayBGM();
    }
    public void PlaySound()
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
    }
}
