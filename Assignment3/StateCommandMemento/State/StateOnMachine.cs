using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
   public class StateOnMachine : IMachineState
    {
        

        public void Power()
        {
           
            Console.WriteLine("Turning Machine--------------->>> OFF");
        }

      
    }
}
