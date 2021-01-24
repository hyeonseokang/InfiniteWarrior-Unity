using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuService : MonoBehaviour
{
    public Button clickButton;
    private void Start()
    {
        SoundManager.Instance.PlayBGM();
        clickButton.onClick.AddListener(() =>
        {
            SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        });
    }
}
