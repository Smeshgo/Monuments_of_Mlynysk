using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class User
    {
        public User()
        {
            ArticleUsers = new HashSet<ArticleUser>();
            UserRoles = new HashSet<UserRole>();
        }

        public long IdUser { get; set; }
        public string Usernama { get; set; }
        public string Password { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? CreateUser { get; set; }
        public DateTime? UpdateUser { get; set; }

        public virtual ICollection<ArticleUser> ArticleUsers { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
