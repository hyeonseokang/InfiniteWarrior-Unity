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

    private void Start()
    {
        bool isReverse = PlayerInfo.Instance.GetIsReverse();
        if (isReverse == true)
        {
            keyChangeSelectImage.transform.position = buttonTransform2.position;
        }   
    }
    public void onClickADButton()
    {

    }
    
    public void onChangeKeyTypeToggle1(Button button)
    {
        keyChangeSelectImage.transform.position = buttonTransform1.position;
        PlayerInfo.Instance.SetIsButtonReverse(false);
    }

    public void onChangeKeyTypeToggle2(Button button)
    {
        keyChangeSelectImage.transform.position = buttonTransform2.position;
        PlayerInfo.Instance.SetIsButtonReverse(true);
    }
    public void onChangeSFXToggle(Toggle toggle)
    {
        SoundManager.Instance.SetMuteSFX(!toggle.isOn);
    }
    public void onClickBGMButton(Toggle toggle)
    {
        SoundManager.Instance.SetMuteBGM(!toggle.isOn);
    }
    public void onChangeVibeToggle(Toggle toggle)
    {
        

    }
    public void onClickExitButton()
    {
        settingPanel.SetActive(false);
    }
}
