using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<PlayerInfo>
{
    public SaveData data;

    private void Awake()
    {
        data = SaveService.Instance.Load();
    }
}
