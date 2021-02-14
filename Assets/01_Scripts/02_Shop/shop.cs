using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop : MonoBehaviour
{
    public int currentPlayerCharacter;//현재 
    public int currentSelectedCharacter;//선택된 캐릭터

    public item[] items;
    private GameObject[] lockBlocks;

    public GameObject shopPanel;
    public GameObject ItemPanel;
    public GameObject lockBlockPrefab;

    public TextMeshProUGUI buyButtonText;//구매버튼 text
    public TextMeshProUGUI coinText;//현재 코인 text
    ButtonState buttonState;
    private void Start()
    {
        updateCoinDisplay();
        updateSelectedItem(currentPlayerCharacter);
        items[currentPlayerCharacter].changeState(ItemState.player);
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

    public void updateCoinDisplay()
    {
        coinText.SetText(PlayerInfo.Instance.data.balance.ToString());
    }
    public void onClickExitShop()
    {//나가기 버튼 클릭
        shopPanel.SetActive(false);
    }
    public void onClickBuyingButton()
    {
        item item = items[currentSelectedCharacter];
        switch (item.state)
        {
            case ItemState.none:
                int coin = PlayerInfo.Instance.data.balance;
                if (item.price <= coin)//구매
                {
                    coin -= item.price;

                    item.state = ItemState.player;
                    items[currentPlayerCharacter].state = ItemState.purchased;
                    currentPlayerCharacter = item.id;

                    changeBuyingButton(ButtonState.selected);
                    updateCoinDisplay();
                }
                else
                {

                }
                break;

            case ItemState.purchased:
                item.state = ItemState.player;
                items[currentPlayerCharacter].state = ItemState.purchased;
                currentPlayerCharacter = item.id;

                changeBuyingButton(ButtonState.selected);
                break;
        }

    }

    public void updateSelectedItem(int id)
    {
        items[currentSelectedCharacter].setOutLine(false);

        currentSelectedCharacter = id;
        items[currentSelectedCharacter].setOutLine(true);

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
