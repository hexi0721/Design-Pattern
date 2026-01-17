using System.Collections.Generic;
using UnityEngine;

namespace BuildPatternPractice
{
    
    public class Product
    {
        private List<string> parts = new List<string>();
        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void ShowProduct()
        {
            foreach(string part in parts)
            {
                Debug.Log(part);
            }
        }


    }
}