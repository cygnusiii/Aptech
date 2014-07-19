using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {

        private static int menu()
        {
            int result = 0;
            do
            {
                Console.WriteLine("1. Type student info !");
                Console.WriteLine("2. Show all students !");
                Console.WriteLine("3. Find student !");
                Console.WriteLine("4. Update student !");
                Console.WriteLine("5. Exit");
                Console.Write("Type your choice ! \nNote : You must perform function 1 that you can using the funtions 2,3,4  ! :");
                result = int.Parse(Console.ReadLine());
            } while (true);

            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
