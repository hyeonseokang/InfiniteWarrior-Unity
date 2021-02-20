using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int scoreValue;
    public TextMeshProUGUI scoreText;

    //? 더 할게없는듯..?

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
    }

    public int getScoreValue()
    {
        return scoreValue;
    }
    public void setScoreValue(int scoreValue)
    {
        this.scoreValue = scoreValue;
    }
    public void addScoreValue(int addvalue)
    {
        scoreValue += addvalue;
        updateScoreUI();
    }
    public void updateScoreUI()
    {
        scoreText.SetText(scoreValue.ToString());
    }
}
