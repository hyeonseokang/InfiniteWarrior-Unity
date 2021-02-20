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
        bestscoreText.SetText("BEST :" + PlayerInfo.Instance.data.bestScore);
        playcountText.SetText("PLAY :" + PlayerInfo.Instance.data.playCount);
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
