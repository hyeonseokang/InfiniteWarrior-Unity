using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI playcountText;
    public TextMeshProUGUI bestscoreText;

    public Image characterImage;

    public GameObject shopPanel;
    public GameObject optionPanel;
    // Start is called before the first frame update
    void Start()
    {
       // characterImage.sprite=
        coinText.SetText(PlayerInfo.Instance.data.balance.ToString());
        bestscoreText.SetText("BEST :" + PlayerInfo.Instance.data.bestScore);
        playcountText.SetText("PLAY :" + PlayerInfo.Instance.data.playCount);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickShopButton()
    {
        shopPanel.SetActive(true);
    }
    public void onClickPlayButton()
    {
        SceneManager.LoadScene("02_InGame");
    }
    public void onClickOptionButton()
    {
        optionPanel.SetActive(true);
    }
}
