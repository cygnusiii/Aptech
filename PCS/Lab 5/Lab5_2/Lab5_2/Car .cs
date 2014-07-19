using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    abstract class Car : IProduct, IRank
    {

        private String name;
        private String id;
        private float price;
        private int warrity;
        private float promotionPercent;


        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public String Id
        {
            get { return id; }
            set { id = value; }
        }


        public float Price
        {
            get { return price; }
            set { price = value; }
        }


        public int Warrity
        {
            get { return warrity; }
            set { warrity = value; }
        }


        public float PromotionPercent
        {
            get { return promotionPercent; }
            set { promotionPercent = value; }
        }

        //inplement method of IProduct
        public virtual void ProductInfo()
        {
            Console.WriteLine("Product Name : "+this.Name);
            Console.WriteLine("ID : "+this.Id);
            Console.WriteLine("Price :"+this.Price);
            Console.WriteLine("Warrity : "+this.Warrity);
            Console.WriteLine("Promotion :"+this.Promotion(this.PromotionPercent));
        }

        public float Promotion(float promotionPercent)
        {
            return this.Price - (float)(this.Price * promotionPercent);
        }

        //implement method of IRank

        public String Rank()
        {
            String result = "";
            if (this.Warrity < 365)
            {
                result = "Level 1";
            }
            else if (this.Warrity > 365 && this.Warrity < 730)
            {
                result = "Level 2";
            }
            else result = "Level 3";

            return result;
        }


        public abstract void SupplierInfo();
    }
}
