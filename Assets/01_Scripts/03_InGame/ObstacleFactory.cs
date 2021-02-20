using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObstacleType
{
    Obstacle1,
    BreakBlock,
}

public class ObstacleFactory : FactoryMethod
{
    public Transform parent;
    public GameObject obstacle1;
    public GameObject breakBlock;

    public GameObject CreateMonster(ObstacleType type)
    {
        GameObject obstacle = null;
        switch (type)
        {
            case ObstacleType.Obstacle1:
                obstacle = CreateObject(obstacle1, parent);
                break;
            case ObstacleType.BreakBlock:
                obstacle = CreateObject(breakBlock, parent);
                break;
        }

        return obstacle;
    }
}
