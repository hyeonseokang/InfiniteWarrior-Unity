using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameEventService : Singleton<InGameEventService>
{
    public delegate void HitCharacter();
    public HitCharacter hitCharacterEvent;

    public delegate void EnterGround();
    public EnterGround enterGroundEvent;

    public delegate void DieCharacter();
    public DieCharacter dieCharacterEvent;
}
