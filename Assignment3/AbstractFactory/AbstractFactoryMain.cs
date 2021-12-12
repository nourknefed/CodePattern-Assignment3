using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            Abstractfactory abstractfactory = new();

            Console.WriteLine("write Dog if want to Create a Dog");
            Console.WriteLine("write Cat if want to Create a Cat");

            var input = Console.ReadLine();
            if(input == "Dog")
            {
               var dog = abstractfactory.GetFactory("Dog");
               dog.CreateAnimal();
               
            }
            if (input == "Cat")
            {
                var cat = abstractfactory.GetFactory("Cat");
                cat.CreateAnimal();
            }
            


        }
    }
}
