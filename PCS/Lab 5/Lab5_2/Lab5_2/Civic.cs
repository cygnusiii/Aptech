using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Civic:Car
    {
        private String supplier;
        private String model;

        public String Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public override void SupplierInfo()
        {
            Console.WriteLine("Supplier : " +this.Supplier);
        }

    }
}
