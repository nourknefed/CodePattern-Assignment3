using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
   public class Message
    {
        public string Text { get; set; }
        List<Message> Messages { get; set; }

        public Message(/*string text*/)
        {
            //Text = text;
        }



        public MessageMomento CreateMessage()
        {
            MessageMomento memento = new MessageMomento
            {
                Text = Text
            };
            return memento;
        }

        public void Undo(MessageMomento momento)
        {
            Console.WriteLine("\nUndo Last command --\n");
            Text = momento.Text;

        }
    }
}
