using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Students : Person
    {
        private String stuId;

        public String StuId
        {
            get { return stuId; }
            set { stuId = value; }
        }

        private String stuClass;

        public String StuClass
        {
            get { return stuClass; }
            set { stuClass = value; }
        }

        public Students()
        {

        }

        public Students(String stuId, String name, String stuClass, DateTime dateOfBirth, String country)
            : base(name, dateOfBirth, country)
        {
            this.stuId = stuId;
            this.stuClass = stuClass;
        }

        //input Student
        public override void input()
        {
            bool flag = true;
            base.input();

            //type Student ID 
            do
            {
                Console.WriteLine("Type student ID : ");
                this.StuId = Console.ReadLine();
                if (this.stuId.Equals(""))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

            //type student class
            do
            {
                Console.WriteLine("Type student class : ");
                this.StuClass = Console.ReadLine();
                if (this.StuClass.Equals(""))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);
        }

        //show data

        public override void showData()
        {
            base.showData();
            Console.WriteLine("Student ID: " + this.stuId);
            Console.WriteLine("Class : " + this.stuClass);

        }



    }



}
