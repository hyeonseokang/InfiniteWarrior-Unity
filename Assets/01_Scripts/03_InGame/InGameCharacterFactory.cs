using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCharacterFactory : MonoBehaviour
{
    public List<Character> characters;
    public Transform parent;

    public Character GetCharacter()
    {
        int characterIndex = MenuCharacter.GetCharacterIndex();
        Character character = Instantiate(characters[characterIndex], parent);

        return character;
    }
}
