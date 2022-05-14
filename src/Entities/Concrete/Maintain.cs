using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Maintain : BaseEntity
    {
        public int MaintainTypeId { get; set; }

        public string MaintainValue { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
