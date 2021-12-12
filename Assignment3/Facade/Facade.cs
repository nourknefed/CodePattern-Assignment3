using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class Facade
    {
        public List<char> Chars { get; set; }
        public string Word { get; set; }
        
        public Facade()
        {
           Chars = new();
            
        }

        public void SaveChars(string input)
        {
            var ch1 = input[0];
            var ch2 = input[1];
            var ch3 = input[2];
            var ch4 = input[3];
            var ch5 = input[4];

            Chars.AddRange(new char[] { ch1, ch2, ch3, ch4, ch5 });
           
        }
        
        public string Getword()
        {
            StringBuilder characterList = new();

            for (int i = 0; i < Chars.Count; i++)
            {                
                characterList.Append(Chars[i]);               
            }
            Word = characterList.ToString();
            return Word;


            
        }
    }
}
