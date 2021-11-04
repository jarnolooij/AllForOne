using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string playerName;

    private int money;

    private List<GameObject> units = new List<GameObject>();

    public string PlayerName { get { return this.playerName; } set { this.playerName = value; } }
    public int Money { get { return this.money; } set { this.money = value; } }

    public Player(string playerName)
    {        
        this.playerName = playerName;
        this.money = 100;
    }

    public Player() {
        this.playerName = "Player";
        this.money = 100;
    }
}
