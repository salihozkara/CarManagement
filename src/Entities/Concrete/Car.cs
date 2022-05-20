using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : BaseEntity
    {
       
        public string Plate { get; set; }
        public string Year { get; set; }

        public int CarTypeId { get; set; }

        public string CustomerPhone { get; set; }

        public List<Transaction> Transactions { get; set; }

        public CarType CarType { get; set; }

        override public string ToString()
        {
            return $"{Plate} {Year} {CarType.Name}";
        }

    }
}
