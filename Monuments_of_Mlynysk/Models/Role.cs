using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Monuments_of_Mlynysk.Models
{
    public class Role : BaseModel
    {
        [Key]
        public int id_role { get; set; }
        public string name { get; set; }
        public string status { get; set; }

        public virtual ICollection<User_role> User_role { get; set; }
        public Role()
        {
            User_role = new List<User_role>();
        }
    }
}
