using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class TestGenerics : MonoBehaviour
    {
        void Start()
        {
            //MethodGenerics.PrintNumber<int>(5);
            // MethodGenerics.AddNumbers(1, 1.5);
            // MethodGenerics.AddNumbers(1.5, 1);

            
            ClassGenerics<int> cg = new ClassGenerics<int>(10);
            
            cg.printV();
        }
    }
}