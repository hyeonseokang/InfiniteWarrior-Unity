using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{
    public GameObject resultPopUp;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI currentScoreText;

    public Button homeButton;
    public Button retryButton;

    private void Start()
    {
        homeButton.onClick.AddListener(() =>
        {
            SoundManager.Instance.PlayBGM();
            SceneManager.LoadScene("01_MainMenu");
        });
        retryButton.onClick.AddListener(() =>
        {
            SoundManager.Instance.PlayBGM();
            SceneManager.LoadScene("02_InGame");
        });
    }

    public void ShowResultPopup(int bestScore, int currentScore)
    {
        SoundManager.Instance.PlaySFX(SFX.GameOver);
        SoundManager.Instance.StopBGM();
        StartCoroutine(DelayShowResultPopup(bestScore, currentScore));
    }

    IEnumerator DelayShowResultPopup(int bestScore, int currentScore)
    {
        yield return new WaitForSeconds(1.1f);
        Init(bestScore, currentScore);
        ShowResultPopUp();
        yield return new WaitForSeconds(0.5f);
        
        int ad = Random.Range(0, 10);
        if (ad > 8)
            AdsService.Instance.ShowAd();
    }

    private void Init(int bestScore, int currentScore)
    {
        // 요 부분 수정 하면됨
        bestScoreText.SetText(bestScore.ToString());
        StartCoroutine(CountScoreAnimation(currentScore, bestScore));//코루틴 시작
    }

    private void ShowResultPopUp()
    {
        resultPopUp.SetActive(true);
    }


    //스코어 카운팅
    IEnumerator CountScoreAnimation(float targetScore, int bestScore)
    {
        SoundManager.Instance.PlaySFX(SFX.ScoreUp);
        float curScore = 0;
        float t = 1.0f;
        float offset = (targetScore - curScore) / t;
        while(curScore<targetScore)
        {
            curScore += (offset * Time.deltaTime);
            currentScoreText.SetText(((int)curScore).ToString());
            yield return null;
        }        
        currentScoreText.SetText(targetScore.ToString());

        
        if(targetScore > bestScore)
        {
            PlayerInfo.Instance.SetBestScore((int)targetScore);
            bestScoreText.fontSize = 80.0f;
            bestScoreText.text = ((int)targetScore).ToString();
            for(int i=0;i<2;i++)
            {
                bestScoreText.color = Color.red;
                yield return new WaitForSeconds(0.2f);
                bestScoreText.color = Color.white;
                yield return new WaitForSeconds(0.2f);
            }
            bestScoreText.color = Color.red;
        }
    }

}


