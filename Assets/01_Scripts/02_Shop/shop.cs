using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public int currentPlayerCharacter;//현재 
    public int currentSelectedCharacter;//선택된 캐릭터
    public Text explanText;

    public MenuCharacter menuCharacter;

    public item[] items;
    private GameObject[] lockBlocks;

    public GameObject shopPanel;
    public GameObject ItemPanel;
    public GameObject lockBlockPrefab;

    public TextMeshProUGUI buyButtonText;//구매버튼 text
    public TextMeshProUGUI balanceText;//현재 코인 text
    ButtonState buttonState;
    private void Start()
    {
        updateBalanceDisplay();

        currentPlayerCharacter = MenuCharacter.GetCharacterIndex();

        bool[] purchasedItem = PlayerInfo.Instance.GetPurchasedCharacters();
        for (int i = 0; i < items.Length; i++)
        {
            Debug.LogWarning(purchasedItem[i]);
            if (purchasedItem[i] == true)
            {
                items[i].changeState(ItemState.purchased);
            }
        }
        
        items[currentPlayerCharacter].changeState(ItemState.player);
        updateSelectedItem(currentPlayerCharacter);
        //setLockBlocks();        
    }
    public void changeCurrentCharacter(int n)
    {
        currentPlayerCharacter = n;
    }
    public item getCurrentChracter()
    {
        return items[currentPlayerCharacter];
    }
    public void setCurrentSelectedCharacter(int n)
    {
        currentSelectedCharacter = n;
    }

    public void updateBalanceDisplay()
    {
        balanceText.SetText(PlayerInfo.Instance.GetBalance().ToString());
    }
    public void onClickExitShop()
    {//나가기 버튼 클릭
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        shopPanel.SetActive(false);
    }
    public void onClickBuyingButton()
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        item item = items[currentSelectedCharacter];
        switch (item.state)
        {
            case ItemState.none:
                int balance = PlayerInfo.Instance.GetBalance();
                if (item.price <= balance)//구매
                {
                    PlayerInfo.Instance.SetBalance(balance - item.price);

                    item.state = ItemState.player;
                    items[currentPlayerCharacter].state = ItemState.purchased;
                    currentPlayerCharacter = item.id;
                    PlayerInfo.Instance.SetPurchasedCharacter(item.id);
                    ChangeCharacter(items[item.id].itemname);
                    changeBuyingButton(ButtonState.selected);
                    updateBalanceDisplay();
                }
                else
                {

                }
                break;

            case ItemState.purchased:
                item.state = ItemState.player;
                items[currentPlayerCharacter].state = ItemState.purchased;
                currentPlayerCharacter = item.id;
                ChangeCharacter(items[item.id].itemname);
                changeBuyingButton(ButtonState.selected);
                break;
        }

    }

    private void ChangeCharacter(string characterName)
    {
        PlayerInfo.Instance.SetCharacter(characterName);
        menuCharacter.ChangeCharacterImage();
    }

    public void updateSelectedItem(int id)
    {
        SoundManager.Instance.PlaySFX(SFX.ButtonClick);
        items[currentSelectedCharacter].setOutLine(false);

        currentSelectedCharacter = id;
        items[currentSelectedCharacter].setOutLine(true);
        explanText.text = items[currentSelectedCharacter].itemExplan;

        ItemState s = items[id].state;
        if (s == ItemState.none)
            changeBuyingButton(ButtonState.buy);
        else if (s == ItemState.purchased)
            changeBuyingButton(ButtonState.select);
        else if (s == ItemState.player)
            changeBuyingButton(ButtonState.selected);
    }

    public void changeBuyingButton(ButtonState state)
    {
        buttonState = state;
        switch (buttonState)
        {
            case ButtonState.buy:
                buyButtonText.SetText("buy "+items[currentSelectedCharacter].price);
                break;
            case ButtonState.select:
                buyButtonText.SetText("select");
                break;
            case ButtonState.selected:
                buyButtonText.SetText("selected");
                break;

        }
        
        
    }
    
}
