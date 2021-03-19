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

        InitHpImagePosition();
    }

    private void InitHpImagePosition()
    {
        int count = hpImages.Count;
        float middleIndex = count / 2;
        if (count % 2 == 0)
        {
            middleIndex -= 0.5f;
        }

        for (int i = 0; i < count ; i++)
        {
            float positionX = (i - middleIndex) * 120.0f;
            Vector3 position = hpImages[i].rectTransform.anchoredPosition;
            position.x = positionX;

            hpImages[i].rectTransform.anchoredPosition = position;
        }
    }

    public void DecreaseHP()
    {
        hpImages[hpValue].sprite = emptyHpSprite;
        hpValue -= 1;

        if (hpValue == -1)
        {
            InGameEventService.Instance.dieCharacterEvent();
        }
    }
}
