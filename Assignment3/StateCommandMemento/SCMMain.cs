using Assignment2.StateCommandMemento.Momento;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {

           
            Machine machine = new Machine();
            ICommand command = new Command();
            Message _message = new Message();
            MessageCareTaker messageCareTaker = new MessageCareTaker(_message);


            if(machine._state is StateOffMachine)
            {
                Console.WriteLine("\nThe machine is ------Off---------");

            }
            else
            {
                Console.WriteLine("\nThe machine is ------On---------");
            }

            Console.WriteLine("\npress A to turn On/Off Machine");
            Console.WriteLine("\npress d ---->> to write a message");
            Console.WriteLine("press re ---->> to Redo a message");
            Console.WriteLine("\npress U ---->> to undo a message");
            Console.WriteLine("press S ---->> to see saved messages");
            Console.WriteLine("press R ---->> to Restore");
            Console.WriteLine("press E ---->> exit");



            while (true)
            {
                var userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "a" or "A":
                        machine.Power();
                        break;

                    case "E" or "e":
                        Environment.Exit(0);
                        break;
                }

                if(machine._state is StateOffMachine)
                {
                    
                    switch (userinput)
                    {
                        case "d" or "D":
                            command.GetCommand();
                            break;
                        case "re" or "Re":
                            command.Redo();
                            break;
                        case "s" or "S" or "u" or "U" or "S" or "s":
                            Console.WriteLine("Turn On the machine to run all commands/messages");
                            break;

                    }
                }
                else
                {
                    switch (userinput)
                    {
                        case "s" or "S":
                            foreach (var item in command.CommandMessages)
                            {
                                command.WriteMessage(item);
                                messageCareTaker.SaveMessage();
                                _message.Text = item;
                            }
                            break;
                        case "u" or "U":
                            messageCareTaker.Undo();
                            command.WriteMessage(_message.Text);
                            break;    
                        case "r" or "R":
                            messageCareTaker.Restore();
                            command.Restore();
                            break;
                        case "d" or "D":
                            Console.WriteLine("you can´t send message when it´s on");
                            break;


                    }
                }

                   


                

            }
         }
            


        
    }
}