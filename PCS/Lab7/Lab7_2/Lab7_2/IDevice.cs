using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7_2
{
    interface IDevice
    {
        string Manufacturer { set; get; }
        int Price { set; get; }
        float VAT { get; }
        float NetPrice { get; }
    }
}
