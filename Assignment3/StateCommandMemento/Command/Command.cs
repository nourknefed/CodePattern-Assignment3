using Assignment2.StateCommandMemento.Momento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Command : ICommand
    {
        

        Message Message = new Message();
        public List<string> CommandMessages { get; set; }
        

     

        public Command()
        {
           
            CommandMessages = new();

        }

        public void GetCommand()
        {
            Console.WriteLine("Send a message!");
            var input = Console.ReadLine();
            Message.CreateMessage();
            CommandMessages.Add(input);

        }



        public void WriteMessage(string message)
        {
            
            Console.WriteLine($"The message is:{message}");
        }

        public void showSavedMessages()
        {
           foreach(var m in CommandMessages)
            {
                Console.WriteLine(m);
            }

        }

        public void Redo()
        {
            Console.WriteLine("Redo");
           var command = CommandMessages.LastOrDefault();
            if (CommandMessages.Count > 0)
            {

               
                CommandMessages.Add(command);
                Console.WriteLine(command);
              
            }
            else
            {
                Console.WriteLine("No messages found");
            }
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
           
            if (CommandMessages is not null)
            {
               if(CommandMessages.Count -1 > 0)
                {
                    CommandMessages.RemoveAt(CommandMessages.Count - 1);
                    Console.WriteLine(CommandMessages.LastOrDefault());

                }
                else
                {
                    Console.WriteLine("no message found");
                }

               
            }
            else
            {
                Console.WriteLine("No Messages found");
            }

        }

        public void Restore()
        {

            StateOnMachine state = new StateOnMachine();
            state.Power();
        }

        

    }
}
