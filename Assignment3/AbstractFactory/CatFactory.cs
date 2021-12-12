using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class CatFactory : IFactory
    {
        
        public IAnimal CreateAnimal()
        {
            Console.WriteLine($"Write the cat name");
            var name = Console.ReadLine();

            Console.WriteLine($"New Cat created...It´s Name is: {name}");

            return new Cat(name);
        }
    }
}
