using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Bill:IEntity
    {
        public int BillId { get; set; }
        public string No { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int ForeignCurrencyId { get; set; }
        public decimal ForeignCurrency { get; set; }
    }
}
