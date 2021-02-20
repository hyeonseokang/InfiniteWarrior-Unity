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
        Invoke("AttackRayCast", 1.0f);
    }
    public void Hit()
    {
        Destroy(gameObject);
    }

    private void AttackRayCast()
    {
        Vector3 rayPosition = transform.position;
        rayPosition.x -= 1.0f;
        RaycastHit2D hit = Physics2D.Raycast(rayPosition, -transform.right, attackDistance*1000);
        Debug.DrawRay(rayPosition, -transform.right * attackDistance, Color.red, 0.3f);
        if (hit)
        {
            Debug.Log(hit.collider.tag);
            if (hit.collider.CompareTag("character"))
            {
                Debug.Log("character 맞음");
                InGameEventService.Instance.hitCharacterEvent();
            }
        }

        Invoke("Attack", attackTime);
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
