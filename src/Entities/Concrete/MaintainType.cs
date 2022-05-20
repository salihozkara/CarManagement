using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaintainType : BaseEntity
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
