using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObstacleType
{
    Obstacle1,
    Obstacle2,
}

public class ObstacleFactory : FactoryMethod
{
    public Transform parent;
    public GameObject obstacle1;
    public GameObject CreateMonster(ObstacleType type)
    {
        GameObject obstacle = null;
        switch (type)
        {
            case ObstacleType.Obstacle1:
                obstacle = CreateObject(obstacle1, parent);
                break;
        }

        return obstacle;
    }
}
