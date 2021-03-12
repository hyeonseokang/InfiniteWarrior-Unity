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
    
    public static int GetCharacterIndex()
    {
        string name = PlayerInfo.Instance.GetCharacter();

        if (name == "character1")
        {
            return 0;
        }
        else if(name == "character2")
        {
            return 1;
        }
        else if(name == "character3")
        {
            return 2;
        }

        return -1;
    }
    public void ChangeCharacterImage()
    {
        string name = PlayerInfo.Instance.GetCharacter();
        int index = GetCharacterIndex();

        character.gameObject.GetComponent<Animator>().runtimeAnimatorController = characters[index].GetComponent<Animator>().runtimeAnimatorController;
        character.sprite = characters[index].sprite;
    }
}
