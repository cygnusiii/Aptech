using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Workers : Person
    {
        private String job;
        private int salary;

        public String Job
        {
            get { return job; }
            set { job = value; }
        }


        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        // input in sub-class
        public override void input()
        {

            Console.WriteLine("Type name : ");
            base.FName = Console.ReadLine();
            Console.WriteLine("Type date of birth : ");
            base.DateOfBitrh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Type location : ");
            base.Location = Console.ReadLine();
            Console.WriteLine("Type job : ");
            this.Job = Console.ReadLine();
            Console.WriteLine("Type salary : ");
            this.Salary = int.Parse(Console.ReadLine());


        }

        // display in sub-class
        public override void display()
        {

            Console.WriteLine("Name : " + base.FName);
            Console.WriteLine("Date of birth : " + base.DateOfBitrh);
            Console.WriteLine("Location : " + base.Location);
            Console.WriteLine("Job : "+this.Job);
            Console.WriteLine("Salary : "+this.Salary);
        }

    }
}
