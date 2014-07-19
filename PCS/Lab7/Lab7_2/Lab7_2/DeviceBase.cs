using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7_2
{
    abstract class DeviceBase
    {
        private int pro_id;
        private string pro_name;

        public int Pro_id
        {
            get { return pro_id; }
        }



        public string Pro_name
        {
            get { return pro_name; }
            set
            {
                try
                {
                    pro_name = value;
                    if (value.Length < 5) throw new Exception();
                }
                catch (Exception e)
                {
                    Console.WriteLine("You must type pro_name with value length more than 5 characters");
                }
            }
        }

        public DeviceBase()
        {
        }
        public DeviceBase(int pro_id)
        {
            this.pro_id = pro_id;
            this.pro_name = "No name";
        }

        public DeviceBase(int pro_id, string pro_name)
        {
            this.pro_id = pro_id;
            this.pro_name = pro_name;
        }


        abstract virtual void ShowInfo();

    }
}
