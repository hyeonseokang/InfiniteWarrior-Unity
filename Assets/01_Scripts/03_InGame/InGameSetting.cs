//////// 삭제 삭제삭제삭제 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameSetting : MonoBehaviour
{
    public Toggle bgmToggle;
    public Toggle sfxToggle;
    public Toggle vibeToggle;
    public Button homeButton;
    public Button ResumeButton;

    private void Start()
    {
        bgmToggle.onValueChanged.AddListener((bool isOn)=>{
            OnClickBGMToggle(isOn);
        });    
        sfxToggle.onValueChanged.AddListener((bool isOn)=>{
            OnClickSFXToggle(isOn);
        });   
        vibeToggle.onValueChanged.AddListener((bool isOn)=>{
            OnClickVibeToggle(isOn);
        });   
    }

    public void OnClickBGMToggle(bool isOn)
    {
        SoundManager.Instance.SetMuteBGM(isOn);
    }

    public void OnClickSFXToggle(bool isOn)
    {
        SoundManager.Instance.SetMuteSFX(isOn);
    }

    public void OnClickVibeToggle(bool isOn)
    {

    }
}
