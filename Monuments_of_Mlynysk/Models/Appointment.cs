using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            Materials = new HashSet<Material>();
        }

        public long IdAppointment { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAppointment { get; set; }
        public DateTime? Update { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
