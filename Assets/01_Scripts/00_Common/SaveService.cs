using System.Collections;
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

    public static SaveData GetEmptyData()
    {
        SaveData data = new SaveData();
        data.balance = 1000;
        data.bestScore = 0;
        data.playCount = 0;
        data.character = "test1";

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
