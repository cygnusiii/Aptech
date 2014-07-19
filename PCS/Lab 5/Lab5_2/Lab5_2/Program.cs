using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        Civic cv;
        BMV bmv;
        private static int menu()
        {
            int result = 0;
            Console.WriteLine("Garage auto management !");
            Console.WriteLine("1. Type a Civic and a BMV !");
            Console.WriteLine("2. Display all info !");
            Console.WriteLine("3. Display greater promotion ");
            Console.WriteLine("4. Display less promotion");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Type your choice : ");
            result = int.Parse(Console.ReadLine());
            return result;
        }

        private void input()
        {
            cv = new Civic();
            bmv = new BMV();
            //Civic
            Console.WriteLine("Civic information !");
            Console.WriteLine("Type name : ");
            cv.Name = Console.ReadLine();
            Console.WriteLine("Type id : ");
            cv.Id = Console.ReadLine();
            Console.WriteLine("Type Price : ");
            cv.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Type Warrity : ");
            cv.Warrity = int.Parse(Console.ReadLine());
            Console.WriteLine("Type promotion percent :");
            cv.PromotionPercent = float.Parse(Console.ReadLine());
            Console.WriteLine("Type supplier : ");
            cv.Supplier = Console.ReadLine();
            Console.WriteLine("Type model : ");
            cv.Model = Console.ReadLine();

            Console.WriteLine("BMV information !");
            Console.WriteLine("Type name : ");
            bmv.Name = Console.ReadLine();
            Console.WriteLine("Type id : ");
            bmv.Id = Console.ReadLine();
            Console.WriteLine("Type Price : ");
            bmv.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Type Warrity : ");
            bmv.Warrity = int.Parse(Console.ReadLine());
            Console.WriteLine("Type promotion percent :");
            bmv.PromotionPercent = float.Parse(Console.ReadLine());
            Console.WriteLine("Type supplier : ");
            bmv.Supplier = Console.ReadLine();
            Console.WriteLine("Type model : ");
            bmv.Model = Console.ReadLine();

            Console.ReadLine();

        }

        //display
        private void display()
        {
            Console.WriteLine("Civic information !");
            cv.ProductInfo();
            cv.SupplierInfo();

            Console.WriteLine("BMV information !");
            bmv.ProductInfo();

            Console.ReadLine();
        }

        private void displayByPromotion(int i)
        {
            if (i == 1)
            {
                if (cv.Promotion(cv.Price) > bmv.Promotion(bmv.Price))
                {
                    cv.ProductInfo();
                    cv.SupplierInfo();
                }
                else {
                    bmv.ProductInfo();

                }
            }
            else if (i == 2)
            {
                if (cv.Promotion(cv.Price) < bmv.Promotion(bmv.Price))
                {
                    cv.ProductInfo();
                    cv.SupplierInfo();
                }
                else
                {
                    bmv.ProductInfo();

                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int choice = menu();
            do
            {
                switch (choice)
                {
                    case 1: // input
                        p.input();
                        break;
                    case 2:
                        // display
                        p.display();
                        break;
                    case 3:
                        //greater promotion
                        p.displayByPromotion(1);
                        break;
                    case 4:
                        //less promotion
                        p.displayByPromotion(2);
                        break;
                    case 5: System.Environment.Exit(0); break;
                    default: break;
                }

            }
            while (true);
        }
    }
}
