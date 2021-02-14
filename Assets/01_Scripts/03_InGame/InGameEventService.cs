using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameEventService : Singleton<InGameEventService>
{
    public delegate void HitCharacter();
    public HitCharacter hitCharacterEvent;
}
