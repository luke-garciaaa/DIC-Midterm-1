using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC_Actual_Midterm_1
{  
    [Serializable]
    class Product
    {
        public int ProductID { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
