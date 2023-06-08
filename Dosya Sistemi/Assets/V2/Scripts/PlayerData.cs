using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int Puan { get; set; }
    public string Name { get; set; }

    public PlayerData(Player1 player) 
    {
        Puan = player.Puan;
        Name = player.Ad;
    }
}
