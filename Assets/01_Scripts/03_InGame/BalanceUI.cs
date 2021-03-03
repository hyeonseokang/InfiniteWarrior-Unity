using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BalanceUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI balacneText;

    private void Start()
    {
        SetBalacneText(PlayerInfo.Instance.GetBalance().ToString());    
        InGameEventService.Instance.coinUpdateEvent += UpdateCoin;
    }

    private void UpdateCoin()
    {
        PlayerInfo.Instance.SetBalance(PlayerInfo.Instance.GetBalance() + 1);
        SetBalacneText(PlayerInfo.Instance.GetBalance().ToString());
    }

    private void SetBalacneText(string text)
    {
        balacneText.SetText(text);
    }
}
