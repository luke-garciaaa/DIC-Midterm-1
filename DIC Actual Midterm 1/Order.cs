using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC_Actual_Midterm_1
{  
    [Serializable]
    class Order
    {
        public string Customername { get; set; }

        public int OrderID { get; set; }
        public string OrderPrice { get; set; }
        public string ordername { get; set; }
    }
}
