using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public TextMeshProUGUI playcountText;
    public TextMeshProUGUI bestscoreText;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlayBGM();
        bestscoreText.SetText("최고점수 :" + PlayerInfo.Instance.bestScore);
        playcountText.SetText("플레이 횟수 :" + PlayerInfo.Instance.playCount);
    }
    private void Update()
    {
        if (Input.touchCount>0 || Input.GetMouseButtonDown(0))
        {
            MoveNextScene();
        }
    }

    public void MoveNextScene()
    {
        SceneManager.LoadScene("01_MainMenu");
    }
}
