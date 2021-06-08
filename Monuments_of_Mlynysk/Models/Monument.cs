using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class Monument
    {
        public Monument()
        {
            MaterialMonuments = new HashSet<MaterialMonument>();
            MonumentWorkers = new HashSet<MonumentWorker>();
        }

        public long IdMonument { get; set; }
        public decimal Prise { get; set; }
        public long IdPhoto { get; set; }

        public virtual Photo IdPhotoNavigation { get; set; }
        public virtual ICollection<MaterialMonument> MaterialMonuments { get; set; }
        public virtual ICollection<MonumentWorker> MonumentWorkers { get; set; }
    }
}
