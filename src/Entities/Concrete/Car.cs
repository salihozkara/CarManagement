using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        public string Plate { get; set; }

        public int CarTypeID { get; set; }

        public string CustomerPhone { get; set; }

        public List<Transaction> Transactions { get; set; }

        public CarType CarType { get; set; }

    }
}
