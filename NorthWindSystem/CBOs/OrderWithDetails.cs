using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindSystem.CBOs
{
    public class OrderWithDetails
    {
        public short ItemQty { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
    }
}
