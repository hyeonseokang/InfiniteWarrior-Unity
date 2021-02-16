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
        Init(bestScore, currentScore);
        ShowResultPopUp();
    }

    private void Init(int bestScore, int currentScore)
    {
        // 요 부분 수정 하면됨
        bestScoreText.SetText(bestScore.ToString());
        currentScoreText.SetText(currentScore.ToString());
    }

    private void ShowResultPopUp()
    {
        resultPopUp.SetActive(true);
    }
}
