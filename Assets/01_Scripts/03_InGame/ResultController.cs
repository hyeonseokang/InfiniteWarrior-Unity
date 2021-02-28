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
            SceneManager.LoadScene("01_MainMenu");
        });
        retryButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("02_InGame");
        });
    }

    public void ShowResultPopup(int bestScore, int currentScore)
    {
        StartCoroutine(DelayShowResultPopup(bestScore, currentScore));
    }

    IEnumerator DelayShowResultPopup(int bestScore, int currentScore)
    {
        yield return new WaitForSeconds(1.1f);
        if(currentScore > bestScore)
        {
            PlayerInfo.Instance.SetBestScore(currentScore);
        }
        Init(bestScore, currentScore);
        ShowResultPopUp();
    }

    private void Init(int bestScore, int currentScore)
    {
        // 요 부분 수정 하면됨
        bestScoreText.SetText(bestScore.ToString());
        StartCoroutine(CountScoreAnimation(currentScore));//코루틴 시작
    }

    private void ShowResultPopUp()
    {
        resultPopUp.SetActive(true);
    }


    //스코어 카운팅
    IEnumerator CountScoreAnimation(float targetScore) {

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
    }

}


