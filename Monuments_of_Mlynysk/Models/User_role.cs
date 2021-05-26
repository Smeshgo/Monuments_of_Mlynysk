using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Monuments_of_Mlynysk.Models
{
    public class User_role
    {

        [Key]
        [Column(Order = 0)]
        [ForeignKey("Role")]
        public int id_role { get; set; }
        
        [Column(Order = 1)]
        [ForeignKey("User")]
        public int id_user { get; set; }

        public virtual Role Role { get; set; }
        public virtual Users User { get; set; }
        


    }
}
