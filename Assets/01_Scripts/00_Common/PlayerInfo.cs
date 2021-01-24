using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<PlayerInfo>
{
    public int balance { get; set; }
    public int bestScore { get; set; }
    public int playCount { get; set; }
}
