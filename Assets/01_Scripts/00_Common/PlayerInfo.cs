using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<PlayerInfo>
{
    private SaveData data;

    public void SetBestScore(int score)
    {
        data.bestScore = score;
        SaveService.Instance.Save(data);
    }
    public int GetBestScore()
    {
        return data.bestScore;
    }

    public void SetPlayCount(int count)
    {
        data.playCount = count;
        SaveService.Instance.Save(data);
    }
    public int GetPlayCount()
    {
        return data.playCount;
    }

    public void SetBalance(int balance)
    {
        data.balance = balance;
        SaveService.Instance.Save(data);
    }
    public int GetBalance()
    {
        return data.balance;
    }

    public void SetCharacter(string character)
    {
        data.character = character;
        SaveService.Instance.Save(data);
    }
    public string GetCharacter()
    {
        return data.character;
    }

    private void Start()
    {
        data = SaveService.Instance.Load();
    }
}
