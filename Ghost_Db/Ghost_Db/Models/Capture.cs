using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ghost_Db.Models
{
    public class Capture
    {

        // time stamp
        [Required]
        public DateTime TimeStamp { get; set; }
        // Videosnapshot
        [Required]
        public string fileLocation { get; set; }
        // is video/pic...0/1
        [Required]
        public bool state { get; set; }
        //GHOST FK
        public int GhostID { get; set; }
        public Ghost Ghost { get; set; }
    }
}
