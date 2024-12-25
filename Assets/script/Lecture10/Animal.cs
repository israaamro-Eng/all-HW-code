using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

namespace Lecture10
{
    public class Animal
    { 
        public string name;
        public Animal(string name)
        {
            this.name = name;
        }
        
        public virtual void MakeSound()
        {
            Debug.Log("Animal Noise");
        }

       

    }
}