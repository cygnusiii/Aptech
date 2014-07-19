using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7_2
{
    class Laptop : DeviceBase, IDevice
    {
        private int proPrice;

        public int ProPrice
        {
            get { return proPrice; }
            set { proPrice = value; }
        }
        private float VAT;
        private string manufacturer;

        public Laptop(int pro_id)
            : base(pro_id)
        {
            this.proPrice = 0;
            this.VAT = 0.1f;
        }


        public Laptop(int pro_id, string pro_name, int price)
            : base(pro_id, pro_name)
        {
            this.proPrice = price;
            this.VAT = 0.1f;
        }




    }
}
