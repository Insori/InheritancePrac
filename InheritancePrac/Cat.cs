using System;

namespace InheritancePrac
{
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }

        public void TestB()
        {
            //Private();
            Protected();    //파생 클래스에서 접근 가능
            Public();
        }
    }
}