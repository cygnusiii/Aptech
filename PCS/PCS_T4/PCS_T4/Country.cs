using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS_T4
{
    class Country
    {

        private string cName;

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }
        private double s;

        public double S
        {
            get { return s; }
            set { s = value; }
        }
        private long numOfPeople;

        public long NumOfPeople
        {
            get { return numOfPeople; }
            set { numOfPeople = value; }
        }


        public Country()
        {

        }

        public Country(string cName,double s, long numOfPeople)
        {
            this.cName = cName;
            this.s = s;
            this.numOfPeople = numOfPeople;

        }

        public void input()
        {
            Console.WriteLine("Type country name :");
            this.CName = Console.ReadLine();
            Console.WriteLine("Type country s :");
            this.S = double.Parse(Console.ReadLine());
            Console.WriteLine("Type number of country :");
            this.NumOfPeople = long.Parse(Console.ReadLine());
        }


        public void display()
        {
            Console.WriteLine("Country Name : "+this.CName);
            Console.WriteLine("County S : "+this.S);
            Console.WriteLine("Number of people : "+this.NumOfPeople);
        }


    }
}
