﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int CarID { get; set; }

        public int MaintainID { get; set; }

        public int LastOdo { get; set; }

        public DateTime LastDate { get; set; }

        public string Note { get; set; }

        public Car Car { get; set; }

        public Maintain Maintain { get; set; }


    }
}