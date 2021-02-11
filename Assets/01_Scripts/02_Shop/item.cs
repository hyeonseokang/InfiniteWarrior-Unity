using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemState { none, purchased,player};
public enum ButtonState { buy, select , selected};
public class item : MonoBehaviour
{
    public shop shoppingManager;

    public int id;
    public string itemname;
    public int price;
    public int speed;
    public ItemState state = ItemState.none;

    private Outline outline;

    public void Awake()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }
    public void setOutLine(bool value)
    {
        outline.enabled = value;
    }
  
    public void changeState(ItemState s)
    {
        state = s;
    }
    public void OnClickItem()
    {
        shoppingManager.updateSelectedItem(id);

    }

    

}
