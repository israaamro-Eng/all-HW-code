using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public struct Position
    {
        public float x;
        public float y;
        public float z;

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void PrintPosition()
        {
            Debug.Log("value of x , y and z=" + "" + x + "," + y + "," + z);
        }

    }
}