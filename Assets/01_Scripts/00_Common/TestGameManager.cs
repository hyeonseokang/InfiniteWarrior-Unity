using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    void Start()
    {
        bool isMinusCoin = GameManager.Instance.AddCoin(-50);
        if (isMinusCoin)
        {
            // 만약 가지고있는 코인이 마이너스가 된다면 관련 처리를 여기서
        }
    }
}
