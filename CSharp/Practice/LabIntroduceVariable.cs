using System;

namespace Practice
{
    public class LabIntroduceVariable
    {
        public void Main()
        {
            Console.WriteLine($"Today is {DateTime.Now.Date}");
            this.Log($"Today is {DateTime.Now.Date}");
        }

        private void Log(string message)
        {
            // Not Implement
        }
    }
}