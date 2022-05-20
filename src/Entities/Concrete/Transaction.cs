using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Transaction : BaseEntity
    {
        public int CarId { get; set; }

        public int MaintainId { get; set; }

        public string LastOdo { get; set; }

        public DateTime LastDate { get; set; }

        public string Note { get; set; }

        public Car Car { get; set; }

        public Maintain Maintain { get; set; }

        override public string ToString()
        {
            return $"{Maintain.MaintainType} {Maintain.Value} {Car.Plate}";
        }

    }
}
