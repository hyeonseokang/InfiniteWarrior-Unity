﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class SaveData
{
    public int balance;
    public int bestScore;
    public int playCount;
    public string character;
    public bool[] purchasedCharacters;
    public bool isButtonReverse;
    public bool isAds;

    public static SaveData GetEmptyData()
    {
        SaveData data = new SaveData();
        data.balance = 1000;
        data.bestScore = 0;
        data.playCount = 0;
        data.character = "character1";
        data.purchasedCharacters = new bool[3];
        data.purchasedCharacters[0] = true;
        data.purchasedCharacters[1] = false;
        data.purchasedCharacters[2] = false;
        data.isButtonReverse = false;
        data.isAds = true;
        return data;
    }
}

public class SaveService : Singleton<SaveService>
{
    private string dataPath;

    private void Awake()
    {
        dataPath = Application.persistentDataPath + "/dt.iw";
        Debug.Log(dataPath);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerInfo.Instance.SetBalance(5000);
        }
    }
    
    public void Save(SaveData data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(dataPath);

        Debug.Log("save 함 " + dataPath);
        bf.Serialize(file, data);
        file.Close();
    }

    public SaveData Load()
    {
        if(File.Exists(dataPath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(dataPath, FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();

            return data;
        }

        Save(SaveData.GetEmptyData());
        return SaveData.GetEmptyData();
    }
}
