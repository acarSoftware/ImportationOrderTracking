using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public Company Company { get; set; }
        public Proforma Proforma { get; set; }
        public  Bill Bill { get; set; }
        public Payment Payment { get; set; }
        public  Shipper Shipper { get; set; }
        public Insurer Insurer { get; set; }
        public  Freight Freight { get; set; }
        public  Product Product { get; set; }
    }
}
