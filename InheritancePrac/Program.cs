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
        static void Main(string[] args)
        {
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
