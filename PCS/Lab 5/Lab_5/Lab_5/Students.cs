
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Students : Person
    {
        private String className;
        private float avMark;

        public String ClassName
        {
            get { return className; }
            set { className = value; }
        }


        public float AvMark
        {
            get { return avMark; }
            set { avMark = value; }
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
            Console.WriteLine("Type Class Name : ");
            this.ClassName = Console.ReadLine();
            Console.WriteLine("Type AvMark : ");
            this.AvMark = float.Parse(Console.ReadLine());


        }

        // display in sub-class
        public override void display()
        {

            Console.WriteLine("Name : " + base.FName);
            Console.WriteLine("Date of birth : " + base.DateOfBitrh);
            Console.WriteLine("Location : " + base.Location);
            Console.WriteLine("Class Name : " + this.ClassName);
            Console.WriteLine("AvMark : " + this.AvMark);
        }
    }
}
