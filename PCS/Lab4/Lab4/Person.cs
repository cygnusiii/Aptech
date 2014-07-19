using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab4
{
    class Person
    {

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private String country;

        public String Country
        {
            get { return country; }
            set { country = value; }
        }


        public Person()
        {

        }

        public Person(String name, DateTime dateOfBirth, String country)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.country = country;
        }

        // input data
        public virtual void input()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Type name : ");
                this.Name = Console.ReadLine();
                if (this.name.Equals(""))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

            // type date of birth
            do
            {
                Console.WriteLine("Type date of birth : ");

                try
                {
                    this.DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "M/d/yyyy", CultureInfo.InvariantCulture);
                    flag = true;
                }
                catch (Exception ex)
                {
                    flag = false;
                }

            } while (!flag);

            //type country
            do
            {
                Console.WriteLine("Type country : ");
                this.Country = Console.ReadLine();
                if (this.country.Equals(""))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

        }


        // show data

        public virtual void showData()
        {

            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Date of birth : " + this.dateOfBirth.ToString("M/d/yyyy"));
            Console.WriteLine("Country : " + this.country);

        }




    }
}
