using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public ObstacleFactory obstacleFactory;
    public List<GameObject> mapObjects;
    public float deltaMoveX;

    public Transform parent;
    public GameObject blockObject;
    public void MoveMap()
    {
        for (int i = 0; i < mapObjects.Count; i++)
        {
            StartCoroutine(MoveAnimation(mapObjects[i]));
        }
    }

    public void CreateRandomMap()
    {
        int randomValue = Random.Range(0, 100);
        GameObject createObject = null;
        if(randomValue >= 80)
        {
            createObject = obstacleFactory.CreateMonster(ObstacleType.Obstacle1);
        }
        else
        {
            createObject = Instantiate(blockObject, parent);
        }

        
        int lastIndex = mapObjects.Count - 1;
        Vector3 createPosition = mapObjects[lastIndex].transform.position;
        createPosition.x += deltaMoveX;

        createObject.transform.position = createPosition;

        mapObjects.Add(createObject);
    }

    public void RemoveObject(GameObject removeObject)
    {
        mapObjects.Remove(removeObject);
        Destroy(removeObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CreateRandomMap();
            RemoveObject(mapObjects[0]);
            Debug.Log("시작");
            MoveMap();
        }
    }

    IEnumerator MoveAnimation(GameObject moveObject)
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
