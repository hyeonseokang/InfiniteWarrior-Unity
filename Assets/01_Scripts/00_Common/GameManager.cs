// 곧 지워질 예정 PlayerInfo 클래스로 대체d
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int coin
    {
        get;
        private set;
    }

    private void Awake()
    {
        coin = 0;
    }

    public bool AddCoin(int addCoin)
    {
        if(coin + addCoin < 0)
        {
            Debug.LogError("코인이 마이너스 됨");
            return true;
        }

        coin += addCoin;

        return false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddCoin(100);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            AddCoin(-100);
        }
        else if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(coin);
        }
    }
}
