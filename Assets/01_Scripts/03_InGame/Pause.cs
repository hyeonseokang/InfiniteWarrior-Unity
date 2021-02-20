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
        currentScoreText.SetText("2000");
    }
    
    public void onChangeSFXToggle(Toggle toggle)
    {
        SoundManager.Instance.SetMuteSFX(!toggle.isOn);
    }
    public void onClickBGMToggle(Toggle toggle)
    {
        SoundManager.Instance.SetMuteBGM(!toggle.isOn);
    }
    public void onChangeVibeToggle(Toggle toggle)
    {


    }
    public void onClickHomeButton()
    {
        ingame.Continue();
        SceneManager.LoadScene("01_MainMenu");
    }
    public void onClickExitButton()
    {
        ingame.Continue();
        pausePanel.SetActive(false);
    }
}
