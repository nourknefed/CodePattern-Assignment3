using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Momento
{
    class MessageCareTaker
    {
        public Message _message;
        public List<MessageMomento> momentosList;
        
        public MessageMomento Momento { get; set; }

        public MessageCareTaker(Message message)
        {
            _message = message;
            momentosList = new();   
          
        }


        public void SaveMessage()
        {
            var savedmessage = _message.CreateMessage();
            momentosList.Add(savedmessage); 
        }

        public void Undo()
        {
            if (momentosList.Count == 0)
            {
                return;
            }
            var lastmomento = momentosList.Last();
            _message.Undo(lastmomento);
            momentosList.Remove(lastmomento);
        }
        public void Restore()
        {
            if (momentosList.Count > 0)
            {
               
                momentosList.Clear();
                Console.WriteLine("Memento list is cleared now.");
               
            }
            
        }


    }
}
