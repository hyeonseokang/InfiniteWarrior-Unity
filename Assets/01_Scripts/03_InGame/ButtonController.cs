using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Transform button1;
    public Transform button2;

    public void ChangeButtonPosition(bool isReverse)
    {
        if(isReverse == true)
        {
            Vector3 temp = button1.position;
            button1.position = button2.position;
            button2.position = temp;
        }
    }
}
