using System;
using System.Collections.Generic;

namespace Practice
{
    public class LabIntroduceField
    {
        public void Main()
        {
            // 請將 randomSet Introduce Field
            var randomSet = new List<int>();

            var random = new Random();
            randomSet.Add(random.Next());
            randomSet.Add(random.Next());
            randomSet.Add(random.Next());
        }
    }
}