using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public GameObject settingPanel;
    public Image keyChangeSelectImage;
    public Transform buttonTransform1;
    public Transform buttonTransform2;
    public Button adButton;

    private void Start()
    {
        bool isReverse = PlayerInfo.Instance.GetIsReverse();
        if (isReverse == true)
        {
            keyChangeSelectImage.transform.position = buttonTransform2.position;
        }

        if (PlayerInfo.Instance.GetIsAds() == false)
        {
            adButton.gameObject.SetActive(false);
        }
    }
    public void onClickADButton()
    {
        PlayerInfo.Instance.SetIsAds(false);
        adButton.gameObject.SetActive(false);
    }
    
    public void onChangeKeyTypeToggle1(Button button)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        keyChangeSelectImage.transform.position = buttonTransform1.position;
        PlayerInfo.Instance.SetIsButtonReverse(false);
    }

    public void onChangeKeyTypeToggle2(Button button)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        keyChangeSelectImage.transform.position = buttonTransform2.position;
        PlayerInfo.Instance.SetIsButtonReverse(true);
    }
    public void onChangeSFXToggle(Toggle toggle)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        SoundManager.Instance.SetMuteSFX(!toggle.isOn);
    }
    public void onClickBGMButton(Toggle toggle)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        SoundManager.Instance.SetMuteBGM(!toggle.isOn);
    }
    public void onChangeVibeToggle(Toggle toggle)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        VibrateManager.Instance.SetMute(!toggle.isOn);
    }
    public void onClickExitButton()
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        settingPanel.SetActive(false);
    }
}
