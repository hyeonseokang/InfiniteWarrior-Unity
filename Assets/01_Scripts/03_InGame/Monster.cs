using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonster
{
    void Hit();
}

public abstract class Monster : MonoBehaviour, IMonster
{
    public float attackDistance = 5.0f;
    public void Attack()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, attackDistance);
        
        if (hit)
        {
            if (hit.collider.CompareTag("character"))
            {
                InGameEventService.Instance.hitCharacterEvent();
            }
        }
    }
    public void Hit()
    {
        Destroy(gameObject);
    }

    public static IMonster CheckMonster(GameObject checkObject)
    {
        IMonster monster = checkObject.GetComponent<Monster>();

        if (monster == null)
        {
            return new EmptyMonster();
        }

        return monster;
    }
}
