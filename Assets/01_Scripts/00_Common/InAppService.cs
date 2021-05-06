using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAppService : MonoBehaviour
{
    public void BuyCoin(int coin)
    {
        int currentCoin = PlayerInfo.Instance.GetBalance();
        PlayerInfo.Instance.SetBalance(currentCoin + coin);

        InGameEventService.Instance.coinUpdateEvent();
    }
}
