using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Insurer:IEntity
    {
        public int InsurerId { get; set; }
        public string InsurerName { get; set; }
    }
}
