using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment18_1
{
    public class Inventory
    {
        private List<string> list = new List<string>();

        public void AddItem(string item)
        {
            list.Add(item);
        }

        public void ShowItems()
        {
            foreach (string n in list)
            {
                Debug.Log(n);
            }
        }


        public static Inventory operator +(Inventory potions, Inventory elixirs)
        {
            Inventory result = new Inventory();
            result.list.AddRange(potions.list); // إضافة أسماء القائمة الأولى
            result.list.AddRange(elixirs.list); // إضافة أسماء القائمة الثانية
            return result;
        }
    }
}
