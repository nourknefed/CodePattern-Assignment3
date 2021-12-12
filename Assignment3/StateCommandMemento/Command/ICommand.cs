using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    public interface ICommand
    {
     // string Message { get; set; }

        void WriteMessage(string messsage);
        void Undo();
        void Restore();
        void Redo();
        void showSavedMessages();
        public void GetCommand();

        public List<string> CommandMessages { get; set; }
        

    }
}