using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public GameObject settingPanel;
    public Image keyChangeSelectImage;
    public void onClickADButton()
    {

    }
    
    public void onChangeKeyTypeToggle1(Button button)
    {
        keyChangeSelectImage.transform.position = button.transform.position;
    }

    public void onChangeKeyTypeToggle2(Button button)
    {
        keyChangeSelectImage.transform.position = button.transform.position;
    }
    public void onChangeSFXToggle(Toggle toggle)
    {
        SoundManager.Instance.SetMuteSFX(toggle.isOn);
    }
    public void onClickBGMButton(Toggle toggle)
    {
        SoundManager.Instance.SetMuteBGM(toggle.isOn);
    }
    public void onChangeVibeToggle(Toggle toggle)
    {
        

    }
    public void onClickExitButton()
    {
        settingPanel.SetActive(false);
    }
}
