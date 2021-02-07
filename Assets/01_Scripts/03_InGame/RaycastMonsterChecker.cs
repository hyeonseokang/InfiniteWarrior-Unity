using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMonsterChecker : MonoBehaviour
{
    public static IMonster GetHitMonster(GameObject hitObject)
    {
        IMonster monster = hitObject.GetComponent<Monster>();

        if(monster == null)
        {
            return new EmptyMonster();
        }

        return monster;
    }
}
