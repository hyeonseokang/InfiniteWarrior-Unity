using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    private Vector3 originPos;
    public GameObject shakingObject;
    public float shakeValue;
    public float shakeTime;
    private void Start()
    {
        originPos = shakingObject.transform.localPosition;
    }
    public void StartShake()
    {
        StartCoroutine(ShakeAnimation(shakeTime));
    }
    private IEnumerator ShakeAnimation(float time)
    {
        originPos = shakingObject.transform.localPosition;
        float timer = 0;
        Vector3 velocity = Vector3.zero;
        while(timer <= time)
        {
            originPos = shakingObject.transform.localPosition - velocity;
            velocity = (Vector3)Random.insideUnitCircle * shakeValue;
            shakingObject.transform.localPosition =  velocity + originPos;
 
            timer += Time.deltaTime;
            yield return null;
        }
        shakingObject.transform.localPosition = originPos;
    }
}
