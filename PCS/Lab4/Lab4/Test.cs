using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Test
    {

        public Test()
        {
            Console.WriteLine("Person information !");
            Person p = new Person();
            p.input();
            Console.WriteLine("-----------------------------");
            p.showData();

        }
    }
}
