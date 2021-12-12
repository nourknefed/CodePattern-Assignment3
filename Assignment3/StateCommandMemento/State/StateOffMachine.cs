using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class StateOffMachine : IMachineState
    {
        

       // ICommand command { get; set; }
       // Command Command { get; set; }
        
        public StateOffMachine()
        {
            
        }


        public void Power()
        {
           
            
            Console.WriteLine("Turning machine--------------->>> ON");
        }

        

        

        
    }
}
