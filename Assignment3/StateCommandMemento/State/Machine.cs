using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Machine : IMachineState
    {
       
        public bool State { get; set; }

        public IMachineState _state { get; set; }
        private ICommand Command { get; set; }
        

        public Machine()
        {
            _state = new StateOffMachine();
        }
        public void Power()
        {
            _state.Power();

            if (_state is StateOffMachine)
            {
                _state = new StateOnMachine();
                State = true;
              
                

               
                
            }
            else
            {
                State = false;
                _state = new StateOffMachine();

            }
        }

       
    }
}
