using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
           GameContainer<string> GC=new GameContainer<string>();

           GC.SetItem("Healing Potion");

           GC.GetItem();

           GameUtils.DescribeItem<string>("Healing Potion");
        }
    }
}