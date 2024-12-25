using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GameManager2 : MonoBehaviour
{
    Player hero;
    Enemy enemy1;
    void Start()
    {
        hero = new Player("aqel", 80);
        enemy1 = new Enemy("netn", 30);

        Debug.Log("the hero name and health=" + " " + hero.Name + " , " + hero.Health);
        Debug.Log("the Enemy name and health=" + " " + enemy1.Name + " , " + enemy1.Health);

        Debug.Log("the hero make an attack on the enemy, the enemy health=" + " " + enemy1.Attack(28));
        Debug.Log("the doctor heal the hero, the hero health=" + " " + hero.Heal(60));

    }

}
