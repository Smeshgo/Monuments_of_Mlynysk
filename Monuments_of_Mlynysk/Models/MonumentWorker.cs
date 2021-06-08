using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class MonumentWorker
    {
        public long IdMonument { get; set; }
        public long IdWorker { get; set; }

        public virtual Monument IdMonumentNavigation { get; set; }
        public virtual Worker IdWorkerNavigation { get; set; }
    }
}
