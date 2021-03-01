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
    }

    public void SetBalacneText(string text)
    {
        balacneText.SetText(text);
    }
}
