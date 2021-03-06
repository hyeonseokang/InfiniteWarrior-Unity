using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballFactory : FactoryMethod
{
    public Transform parent;
    public GameObject fireballObject;
    public GameObject warningUI;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("왜 안눌리지");
            CreateFireball();
        }
    }

    public GameObject CreateFireball()
    {
        GameObject fireball = CreateObject(fireballObject, parent);
        StartCoroutine(StartWarningAnimation(fireball));

        return fireball;
    }

    IEnumerator StartWarningAnimation(GameObject fireball)
    {
        Vector3 warningPosition = warningUI.transform.position;
        warningPosition.y = fireball.transform.position.y;
        warningUI.transform.position = warningPosition;

        for(int i = 0 ; i < 4 ; i++)
        {
            warningUI.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            warningUI.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
