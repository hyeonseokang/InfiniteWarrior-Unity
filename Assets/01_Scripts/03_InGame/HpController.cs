using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{
    public Transform parent;
    public Image hpPrefab;
    public Sprite emptyHpSprite;
    public List<Image> hpImages;
    private int hpValue;

    public void SetHP(int value)
    {
        hpValue = value - 1;
        for (int i=0;i<value;i++)
        {
            Image hpImage = Instantiate(hpPrefab, parent);
            hpImages.Add(hpImage);
        }
    }

    public void DecreaseHP()
    {
        hpImages[hpValue].sprite = emptyHpSprite;
        hpValue -= 1;
    }
}
