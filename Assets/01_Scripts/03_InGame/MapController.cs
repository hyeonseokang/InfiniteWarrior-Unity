using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public ObstacleFactory obstacleFactory;
    public MonsterFactory monsterFactory;
    public List<GameObject> mapObjects;
    public List<GameObject> monsterObjects;

    public float deltaMoveX;

    public Transform parent;
    public GameObject blockObject;
    public void MoveMap()
    {
        for (int i = 0; i < mapObjects.Count; i++)
        {
            StartCoroutine(MoveAnimation(mapObjects[i]));
        }

        for (int i = 0; i < monsterObjects.Count; i++)
        {
            StartCoroutine(MoveAnimation(monsterObjects[i]));
        }
    }

    public void CreateRandomMap()
    {
        int lastIndex = mapObjects.Count - 1;
        Vector3 createPosition = mapObjects[lastIndex].transform.position;
        createPosition.x += deltaMoveX;

        int randomValue = Random.Range(0, 100);
        GameObject createObject = null;
        if(randomValue >= 80)
        {
            createObject = CreateRandomObstacle();
        }
        else
        {
            createObject = Instantiate(blockObject, parent);
            GameObject monster = CreateRandomMonster();
            
            Vector3 monsterPosition = monster.transform.position;
            monsterPosition.x = createPosition.x;
            monsterPosition.z = createPosition.z;

            monster.transform.position = monsterPosition;
            monsterObjects.Add(monster);
        }
        
        createObject.transform.position = createPosition;
        mapObjects.Add(createObject);
    }

    public GameObject CreateRandomObstacle()
    {
        GameObject obstacle = null;

        int value = Random.Range(0, 100);
        if(value >= 60)
        {
            obstacle = obstacleFactory.CreateMonster(ObstacleType.BreakBlock);
        }
        else
        {
            obstacle = obstacleFactory.CreateMonster(ObstacleType.Obstacle1);
        }

        return obstacle;
    }

    public void RemoveObject(GameObject removeObject)
    {
        mapObjects.Remove(removeObject);
        Destroy(removeObject);
    }

    private GameObject CreateRandomMonster()
    {
        int value = Random.Range(0, 100);
        GameObject monster = null;
        if (value > 50)
        {
            monster = monsterFactory.CreateMonster(MonsterType.Monster1);
        }
        else
        {
            monster = new GameObject("nullObject");
        }

        return monster;
    }

    private IEnumerator MoveAnimation(GameObject moveObject)
    {
        Vector3 firstPosition = moveObject.transform.position;
        Vector3 targetPosition = moveObject.transform.position;
        targetPosition.x -= deltaMoveX;
        float value = 0;
        float time = 0.2f;
        while (value < 1.0f)
        {
            value += 0.01f / time;
            moveObject.transform.position = Vector3.Lerp(firstPosition, targetPosition, value);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
