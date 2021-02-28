using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCharacter : MonoBehaviour
{
    public List<SpriteRenderer> characters;
    public SpriteRenderer character;

    private void Start()
    {
        ChangeCharacterImage();
    }

    public void ChangeCharacterImage()
    {
        string name = PlayerInfo.Instance.GetCharacter();

        if (name == "character1")
        {
            Debug.Log("hi");
            character.sprite = characters[0].sprite;
        }
        else if(name == "character2")
        {
            Debug.Log("hi2");
            character.sprite = characters[1].sprite;
        }
        else if(name == "character3")
        {
            Debug.Log("hi3");
            character.sprite = characters[2].sprite;
        }
    }
}
