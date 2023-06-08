using System;

namespace InheritancePrac
{
    internal class Cat : Animal
    {

        public Cat()
        {
            this.Age = 0;
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}