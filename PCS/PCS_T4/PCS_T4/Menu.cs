using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS_T4
{


    class Menu
    {

        Country[] country;

        private int menu()
        {
            int choice = 0;

            Console.WriteLine("1. Type country information !");
            Console.WriteLine("2. Display information !");
            Console.WriteLine("3. Sort data by S !");
            Console.WriteLine("4. Find by name !");
            Console.WriteLine("5. Exit !");

            Console.Write("Type your choice : ");
            choice = int.Parse(Console.ReadLine());

            return choice;

        }



        // input data
        private void _input()
        {
            int n = 0;
            Console.Write("Type number of country n = ");
            n = int.Parse(Console.ReadLine());
            country = new Country[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Country "+(i+1));
                country[i] = new Country();
                country[i].input();
                
            }

        }


        // display data

        private void display()
        {

            Console.WriteLine("List of country !");
            foreach (Country _country in country)
            {
    
                _country.display();
            }
        }

        static void Main(string[] args)
        {
            int choice =0 ;
            bool flag=true;

            Menu menu = new Menu();

            Console.WriteLine("Country Information management !");
            do{
                choice = menu.menu();

                switch (choice) {
                    case 1: menu._input(); Console.ReadLine(); break;
                    case 2: menu.display(); Console.ReadLine(); break;
                    case 3: break;
                    case 4: break;
                    case 5: System.Environment.Exit(0); break;
                    default: break;
                }


            }while(true);


            Console.ReadLine();

        }
    }
}
