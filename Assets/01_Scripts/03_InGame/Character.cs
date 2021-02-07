using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected int hp;
    private float attackDistance = 5.0f;

    public  void Attack()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, attackDistance);
        Debug.DrawRay(transform.position, transform.right * attackDistance, Color.red, 0.3f);

        if (hit)
        {
            if (hit.collider.CompareTag("monster"))
            {
                Monster monster = hit.collider.GetComponent<Monster>();
                monster.Hit();
            }
        }
    }

    public  void Move()
    {

    }
}
