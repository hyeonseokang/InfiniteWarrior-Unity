using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonster
{
    void Hit();
}

public class Monster : MonoBehaviour, IMonster
{
    public float attackTime = 3.0f;
    public float attackDistance = 5.0f;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("Attack", attackTime);
    }
    public void Attack()
    {
        animator.SetTrigger("Attack");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, attackDistance);
        
        if (hit)
        {
            if (hit.collider.CompareTag("character"))
            {
                InGameEventService.Instance.hitCharacterEvent();
            }
        }

        Invoke("Attack", attackTime);
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
