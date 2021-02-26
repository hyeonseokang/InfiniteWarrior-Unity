// Author : 강현서
// Description : Toggle Click 시마다 ison 에 따른 SetActive Custom
// Checkmark 에 넣어주고 이벤트 등록 진행
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCustomImage : MonoBehaviour
{
    public void SetActive(Toggle toggle)
    {
        gameObject.SetActive(toggle.isOn);
    }
}
