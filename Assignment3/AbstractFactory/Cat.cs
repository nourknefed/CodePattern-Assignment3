using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class Cat : ICat,IAnimal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
