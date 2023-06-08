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
                ((Dog)item).Bark();
                ((Cat)item).Meow();

                item.Eat();
                item.Sleep();
            }
        }
    }
}
