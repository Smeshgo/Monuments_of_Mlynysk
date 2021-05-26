using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Monuments_of_Mlynysk.Models
{
    public class Users : BaseModel
    {
        [Key]
        public int id_user { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime update_user { get; set; }
        public DateTime create_user { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string status { get; set; }

        public virtual ICollection<User_role> User_role { get; set; }

        public Users() 
        {
            User_role = new List<User_role>();
        }
        
    }
}
