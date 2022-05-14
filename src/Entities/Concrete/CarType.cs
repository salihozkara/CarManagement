using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarType : BaseEntity
    {
        public string CarTypeName { get; set; }

        public List<Car> Cars { get;set; }
    }
}
