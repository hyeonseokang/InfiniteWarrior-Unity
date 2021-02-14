using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Animator characterAnimator;
    public Rigidbody2D character;
    public void PlayJump()
    {
        characterAnimator.SetTrigger("Jump");
        character.AddForce(Vector2.up * 200.0f);
    }
}
