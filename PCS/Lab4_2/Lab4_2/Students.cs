using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Students
    {

        private String rollNo;

        public String RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private float tMark;

        public float TMark
        {
            get { return tMark; }
            set { tMark = value; }
        }
        private float eMark;

        public float EMark
        {
            get { return eMark; }
            set { eMark = value; }
        }


        // student introduction
        public void studentInfo()
        {

            Console.WriteLine("Student RollNo : " + this.rollNo);
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Age : " + this.age);
            Console.WriteLine("Address : " + this.address);
            Console.WriteLine("tMark : " + this.tMark);
            Console.WriteLine("eMark : " + this.eMark);
        }


        // student information with parametter

        public void studentInfo(float attention)
        {

            Console.WriteLine("Student RollNo : " + this.rollNo);
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Age : " + this.age);
            Console.WriteLine("Address : " + this.address);
            Console.WriteLine("tMark : " + this.tMark);
            Console.WriteLine("eMark : " + this.eMark);
            if (attention <= 0.25)
            {
                Console.WriteLine("Student will be perform the test !");
            }
            else
            {
                Console.WriteLine("Student can't perform the test !");
            }


        }
    }
}
