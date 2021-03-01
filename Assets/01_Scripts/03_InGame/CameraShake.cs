using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 originPos;
    private void Start()
    {
        originPos = transform.localPosition;
    }
    public void Shake()
    {
        StartCoroutine(Shake(0.5f));
    }
    private IEnumerator Shake(float time)
    {
        float timer=0;
        while(timer <= time)
        {
            transform.localPosition = (Vector3)Random.insideUnitCircle * 0.05f + originPos;
 
            timer += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originPos;
    }
}
