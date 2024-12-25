using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player3
{
    public Player3(string name, int health)
    {
        playerCount=playerCount+1;
        this.name = name;
        this.health = health;
    }

   public Player3() : this("", 100)
    {
    }

   /* public Player3()
    {
        name = "";
        health = 100;
        playerCount++;
    }*/



    public string name;
    public int health = 0;
    public static int playerCount = 0;

    // public void IntializePalyer(string playerName, int playerHealth)
    // {
    //     name = playerName;
    //     health = playerHealth;
    //     playerCount++;
    // }
}