using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0f, 0f, 0f))
        {

        }

        public virtual void DisplayInfo()
        {
            Debug.Log("the player name:" + " " + name);
            Debug.Log("the player health:" + " " + Health);
            position.PrintPosition();
        }

        public int Attack(int damage, Character target)
        {
            target.Health = target.Health - damage;
            return target.Health;
        }

        public int Attack(int damage, Character target, string attackType)
        {

            Debug.Log("the attack type was:" + " " + attackType);
            return Attack(damage, target);
        }


    }
}