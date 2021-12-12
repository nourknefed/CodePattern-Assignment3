using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class Abstractfactory
    {
       
        public IFactory GetFactory(string factotyname)
        {
            if(factotyname == "Dog")
            {
                return new DogFactory();

            }
            if(factotyname == "Cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}
