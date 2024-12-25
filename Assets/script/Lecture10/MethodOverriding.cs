using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lecture10;

namespace Lecture10
{
    public class MethodOverriding : MonoBehaviour
    {
        Animal animal;
        Cat cat;
        Kitten kitten;

        Player player = new Player();

      //  Lecture10.Player player=new Lecture10.Player();

        Animal[] animalFarm = new Animal[3];

        Data[] students = new Data[5000];

        void Start()
        {
            animal = new Animal("bosi");
            cat = new Cat("lolo"); 
            kitten = new Kitten();

            Debug.Log(cat.name);

           /* animalFarm[0] = animal;
            animalFarm[1] = cat;
            animalFarm[2] = kitten;
            
            for (int i = 0; i < animalFarm.Length; i++)  // 2
            {
                // Animal animal = animalFarm[i];
                // animal.MakeSound();

                animalFarm[i].MakeSound();
            }*/

            /* animal.MakeSound();
             cat.MakeSound();
             kitten.MakeSound();*/
            // Debug.Log(player.health1);



            /*  Debug.Log(cat.name);

              for (int i = 0; i < students.Length; i++)
              {
                  students[i] = new Data("Subhi", 100);
              }*/

            // animal.name = "Sinjab";
        }
    }
}