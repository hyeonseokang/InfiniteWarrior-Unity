using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected int hp = 3;
    private float attackDistance = 5.0f;

    public int GetHP()
    {
        return hp;
    }

    public  void Attack()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, attackDistance);
        Debug.DrawRay(transform.position, transform.right * attackDistance, Color.red, 0.3f);

        if (hit)
        {
            if (hit.collider.CompareTag("monster"))
            {
                GameObject checkObject = hit.collider.gameObject;
                IMonster monster = Monster.CheckMonster(checkObject);
                monster.Hit();
            }
        }
    }

    public  void Move()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            InGameEventService.Instance.enterGroundEvent();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            hp -= 1;
            InGameEventService.Instance.hitCharacterEvent();
        }
    }
}
