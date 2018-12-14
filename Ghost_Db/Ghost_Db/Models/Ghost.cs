using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ghost_Db.Models
{
    public class Ghost
    {

        [Required]
        public int Serial { get; set; }

        // TYPE FK
        public int TypeID { get; set; }
        public Type Type { get; set; }

    }
}
