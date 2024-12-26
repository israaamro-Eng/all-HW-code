using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier gost;
        Officer shepherd;
        Character[] figure = new Character[2];
        void Start()
        {
            gost = new Soldier("gost", 50, new Position(4f, 5f, 6f));
            shepherd = new Officer("shepherd", 80, new Position(6f, 7f, 8f));

            figure[0] = gost;
            figure[1] = shepherd;

            for (int i = 0; i < figure.Length; i++)
            {
                figure[i].DisplayInfo();
            }



            Debug.Log("shepherd attacked gost , gost health was =" + " " + gost.Health);
            Debug.Log("gost health become=" + " " + gost.Attack(50, gost ,"shooting"));
        }
    }
}