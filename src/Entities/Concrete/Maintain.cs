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

        public string Value { get; set; }

        public List<Transaction> Transactions { get; set; }

        public MaintainType MaintainType { get; set; }

        override public string ToString()
        {
            return Value;
        }
    }
}
