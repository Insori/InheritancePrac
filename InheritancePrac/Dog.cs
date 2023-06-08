using System;

namespace InheritancePrac
{
    internal class Dog : Animal
    {
        public string Color { get; set; }

        public Dog()
        {
            this.Age = 0;
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }
    }
}