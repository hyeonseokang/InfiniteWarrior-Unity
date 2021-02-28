using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Character character;
    
    public void PlayJump()
    {
        character.Jump();
    }

    public void PlayIdle()
    {
        character.Idle();
    }

    public void PlayAttack()
    {
        character.Attack();
    }

    public void PlayHit()
    {
        StartCoroutine(character.StartHitAnimation());
    }
}
