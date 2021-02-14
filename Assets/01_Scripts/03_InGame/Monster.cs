using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonster
{
    void Hit();
}

public abstract class Monster : MonoBehaviour, IMonster
{
    public void Hit()
    {

    }

    public static IMonster CheckMonster(GameObject checkObject)
    {
        IMonster monster = checkObject.GetComponent<Monster>();

        if (monster == null)
        {
            return new EmptyMonster();
        }

        return monster;
    }
}
