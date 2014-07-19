using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    abstract class Person
    {
        private String fName;

        public String FName
        {
            get { return fName; }
            set { fName = value; }
        }
        private DateTime dateOfBitrh;

        public DateTime DateOfBitrh
        {
            get { return dateOfBitrh; }
            set { dateOfBitrh = value; }
        }
        private String location;

        public String Location
        {
            get { return location; }
            set { location = value; }
        }


        public abstract void input();

        public abstract void display();
    }
}
