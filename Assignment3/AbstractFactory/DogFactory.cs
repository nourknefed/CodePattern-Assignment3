using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class DogFactory:IFactory
    {
        
       
        public IAnimal CreateAnimal()
        {
            Console.WriteLine($"Write the dog name");
            var name = Console.ReadLine();
            Console.WriteLine($"New Dog created...It´s Name is: {name}");
            return new Dog(name);
        }
    }
}
