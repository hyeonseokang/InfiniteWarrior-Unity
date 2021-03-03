using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public ObstacleFactory obstacleFactory;
    public MonsterFactory monsterFactory;
    public GameObject coinObject;
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
        GameObject monster = new GameObject("nullObject");
        if(randomValue >= 80)
        {
            createObject = CreateRandomObstacle();
        }
        else
        {
            createObject = Instantiate(blockObject, parent);
            monster = CreateRandomMonster(monster);
            Vector3 monsterPosition = monster.transform.position;
            monsterPosition.x = createPosition.x;
            monsterPosition.z = createPosition.z;

            monster.transform.position = monsterPosition;
        }
        
        createObject.transform.position = createPosition;
        mapObjects.Add(createObject);
        monsterObjects.Add(monster);
        
        RemoveObject(mapObjects[0], mapObjects);
        RemoveObject(monsterObjects[0], monsterObjects);
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

    public void RemoveObject(GameObject removeObject, List<GameObject> list)
    {
        list.Remove(removeObject);
        Destroy(removeObject, 1.0f);
    }

    private GameObject CreateRandomMonster(GameObject nullObject)
    {
        int value = Random.Range(0, 100);
        GameObject monster = nullObject;
        if (value > 80)
        {
            Destroy(nullObject.gameObject);
            monster = monsterFactory.CreateMonster(MonsterType.Monster1);
        }
        else if(value > 50)
        {
            Destroy(nullObject.gameObject);
            monster = Instantiate(coinObject);
        }

        return monster;
    }

    private IEnumerator MoveAnimation(GameObject moveObject)
    {
        float value = 0;
        float time = 0.1f;
        float moveCount = 0;
        Vector3 movePosition;

        while (value < time)
        {
            yield return null;
            value += Time.deltaTime;
            float positionX = deltaMoveX * Time.deltaTime / time;
            moveCount += positionX;

            movePosition = moveObject.transform.position;
            moveObject.transform.Translate(new Vector3(-positionX, 0, 0));
        }

        movePosition = moveObject.transform.position;
        float adjustmentPositionX = (moveCount - deltaMoveX);
        moveObject.transform.Translate(new Vector3(adjustmentPositionX, 0, 0));
    }
}
