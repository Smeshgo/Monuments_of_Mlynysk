using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class UserRole
    {
        public long IdRole { get; set; }
        public long IdUser { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
