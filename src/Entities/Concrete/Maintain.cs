using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Maintain
    {
        [Key]
        public int MaintainID { get; set; }

        public int MaintainTypeID { get; set; }

        public string MaintainValue { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
