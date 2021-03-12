using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 1.0f;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("delete"))
        {
            Destroy(this.gameObject);
        }    
        else if(other.CompareTag("fireballSound"))
        {
            SoundManager.Instance.PlaySFX(SFX.FireBall);
        }
    }
}
