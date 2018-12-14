using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ghost_Db.Models
{
    public class User
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(2048)]
        public string Password { get; set; }
        // string length of 2048 to hash password

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public int Phone { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }

        //GHOST FK
        public int GhostID { get; set; }
        public Ghost Ghost { get; set; }


    }
}
