using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ghost_Db.Models
{
    public class Type
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Options { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

    }
}
