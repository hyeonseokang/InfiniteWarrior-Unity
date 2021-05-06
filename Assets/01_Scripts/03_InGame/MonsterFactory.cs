using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MonsterType
{
    Monster1,
}
public class MonsterFactory : FactoryMethod
{
    public Transform parent;
    public GameObject monster1;
    public GameObject CreateMonster(MonsterType type)
    {
        GameObject monster = null;
        switch(type)
        {
            case MonsterType.Monster1:
                monster = CreateObject(monster1, parent);
                break;
        }

        return monster;
    }
}
