using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject optionPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickShopButton()
    {
        shopPanel.SetActive(true);
    }
    public void onClickPlayButton()
    {

    }
    public void onClickOptionButton()
    {
        optionPanel.SetActive(true);
    }
}
