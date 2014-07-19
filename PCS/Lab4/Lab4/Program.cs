using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            //new Test();
            Students st = new Students();
            st.input();
            Console.WriteLine("-------------");
            st.showData();

            Console.ReadLine();
        }
    }
}
