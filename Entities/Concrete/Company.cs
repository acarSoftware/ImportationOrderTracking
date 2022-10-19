using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Company:IEntity
    {
        public int CompanyId { get; set; }
        public string CountryId { get; set; }
        public string CompanyName { get; set; }
        public AuthorizedPerson AuthorizedPerson { get; set; }
    }
}
