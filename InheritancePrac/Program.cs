using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    internal class Program
    {
        class Parent {
            public static int counter = 0;

            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }

            public void CountParent()
            {
                Parent.counter++;
            }

        }

        class Child : Parent 
        { 
            public void CountChild()
            {
                Child.counter++;
            }

            public Child() : base() { Console.WriteLine("Child() : base(10)");  }

            public Child(string input) : base(input) { Console.WriteLine("Child(string input) : base(inout)"); }
        }

        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Dog d = new Dog();
            d.Public();
            //d.Protected();
            //d.Private();

            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat()
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();

                //방법 1 : as
                Dog dog = item as Dog;
                if(dog != null)
                {
                    dog.Bark();
                }

                Cat cat = item as Cat;
                if(cat != null)
                {
                    cat.Meow();
                }

                //방법 2 : is
                if(item is Dog)
                {
                    ((Dog)item).Bark();
                } else if(item is Cat)
                {
                    ((Cat)item).Meow();
                }
            }
        }
    }
}
