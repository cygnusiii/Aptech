using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Lab7
{
    class Program
    {
        //ArrayList al;
        Hashtable ht;


        //menu 
        public int menu()
        {
            int result = 0;

            Console.WriteLine("1. AceptDetails !");
            Console.WriteLine("2. DisplayDetails !");
            Console.WriteLine("3. Remove by value !");
            Console.WriteLine("4. Find by name !");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Type your choice : ");
            result = int.Parse(Console.ReadLine());

            return result;
        }


        // AceptDetails
        private void AceptDetails()
        {
            string answer;
            //al = new ArrayList();
            ht = new Hashtable();
            int i = 0;
            //Console.WriteLine("Demo ArrayList !");
            Console.WriteLine("Demo Hashtable !");
            do
            {

                Console.WriteLine("Type a name :");
                //al.Add(Console.ReadLine());
                ht.Add(i, Console.ReadLine());

                Console.WriteLine("Do you want to continue ? (Y/N) :");
                answer = Console.ReadLine();
                if (!answer.ToUpper().Equals("Y"))
                {
                    break;
                }
                i++;
            } while (true);
        }


        //DisplayDetails
        private void DisplayDetails()
        {
            int i = 0;
            foreach (string name in ht.Values)
            {
                i++;
                Console.WriteLine("Name " + i + " : " + name);
            }
        }


        //Remove

        private void removeByname()
        {
            Console.WriteLine("Type the name you want to delete : ");
            string name = Console.ReadLine();

            //if (al.Contains(name))
            //{
            //    while (al.Contains(name))
            //    {

            //        al.Remove(name);
            //    }
            //    Console.WriteLine("The names have been deleted !");
            //}
            //else
            //{
            //    Console.WriteLine("The name couldn't found !");
            //}

            bool flag = false;

            while (ht.ContainsValue(name))
            {
                flag = true;
                ICollection key = ht.Keys;
                foreach (object k in key)
                {
                    if (ht[k].Equals(name))
                    {
                        ht.Remove(k);
                        break;
                    }
                }
            }


            if (flag)
                Console.WriteLine("The names have been deleted !");
            else
                Console.WriteLine("The name couldn't found !");

        }

        //find

        private void findByname()
        {
            Console.WriteLine("Type the name you want to find : ");
            string name = Console.ReadLine();
            string str = "";

            //for (int i = 0; i < al.Count; i++)
            //{

            //    if (al[i].Equals(name))
            //    {
            //        Console.WriteLine("Name " + (i + 1) + " : " + name);
            //    }
            //    else

            //        str = "The name couldn't found !";
            //}



            ICollection key = ht.Keys;

            foreach (int k in key)
            {
                if (ht[k].Equals(name))
                    Console.WriteLine(ht[k]);
                else str = "The name couldn't found !";
            }


            if (!str.Equals("")) Console.WriteLine(str); ;
        }

        //check null
        private bool checkNullReference()
        {
            //try
            //{
            //    if (al.Count == 0 || al == null)
            //    {
            //        throw new NullReferenceException();
            //    }
            //}
            //catch (NullReferenceException e)
            //{
            //    return false;
            //}

            try
            {
                if (ht.Count == 0 || ht == null)
                {
                    throw new NullReferenceException();
                }
            }
            catch (NullReferenceException e)
            {
                return false;
            }

            return true;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            string str = "You must type the any name. Before using this function !";
            do
            {
                int choice = p.menu();

                switch (choice)
                {
                    case 1: p.AceptDetails(); break;
                    case 2: if (p.checkNullReference()) p.DisplayDetails(); else Console.WriteLine(str); break;
                    case 3: if (p.checkNullReference()) p.removeByname(); else Console.WriteLine(str); break;
                    case 4: if (p.checkNullReference()) p.findByname(); else Console.WriteLine(str); break;
                    case 5: System.Environment.Exit(0); break;
                    default: break;
                }

            } while (true);
        }
    }
}
