using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public GameObject settingPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickADButton()
    {

    }
    public void onChangeKeyTypeToggle1(Toggle toggle)
    {

    }
    public void onChangeKeyTypeToggle2(Toggle toggle)
    {

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
