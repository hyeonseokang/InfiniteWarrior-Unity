using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonster
{
    void Hit();
}

public abstract class Monster : MonoBehaviour, IMonster
{
    public void Hit()
    {

    }
}
