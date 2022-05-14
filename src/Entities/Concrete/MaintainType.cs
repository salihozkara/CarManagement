using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaintainType
    {
        [Key]
        public int MaintainTypeID { get; set; }

        public string MaintainTypeName { get; set; }
    }
}
