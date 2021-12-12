using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class adapter
    {
        PrintingInts PrintingInts = new();
        ReturningStrings ReturningStrings = new();
        public void Print()
        {
            PrintingInts.Print(Int32.Parse(ReturningStrings.ReturnString()));
        }
    }
}
