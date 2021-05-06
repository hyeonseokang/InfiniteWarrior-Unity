using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Ingame ingame;
    public GameObject pausePanel;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI currentScoreText;

    public Score scoreController;
    // Start is called before the first frame update
    void Start()
    {
        //pausePanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void initPausePanel()
    {
        ingame.SetPause();
        pausePanel.SetActive(true);
        bestScoreText.SetText(PlayerInfo.Instance.GetBestScore().ToString());
        currentScoreText.SetText(scoreController.getScoreValue().ToString());
    }
    
    public void onChangeSFXToggle(Toggle toggle)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        SoundManager.Instance.SetMuteSFX(!toggle.isOn);
    }
    public void onClickBGMToggle(Toggle toggle)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        SoundManager.Instance.SetMuteBGM(!toggle.isOn);
    }
    public void onChangeVibeToggle(Toggle toggle)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        VibrateManager.Instance.SetMute(!toggle.isOn);
    }
    public void onClickHomeButton()
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        ingame.Continue();
        SceneManager.LoadScene("01_MainMenu");
    }
    public void onClickExitButton()
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        ingame.Continue();
        pausePanel.SetActive(false);
    }
}
