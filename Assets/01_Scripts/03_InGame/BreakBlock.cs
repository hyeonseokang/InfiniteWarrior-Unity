using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    public Shake shake;
    private bool isEnable = true;
    private void Break()
    {
        gameObject.AddComponent<Rigidbody2D>().gravityScale = 4.0f;
        Invoke("Disable", 2.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("character"))
        {
            if (isEnable == false)
                return;

            isEnable = false;
            shake.StartShake();
            Invoke("Break", 0.3f);
            
            SoundManager.Instance.PlaySFX(SFX.BreakBlock);
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
