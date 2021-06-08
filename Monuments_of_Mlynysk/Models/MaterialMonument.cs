using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class MaterialMonument
    {
        public long MaterialMonument1 { get; set; }
        public long IdMonument { get; set; }
        public long IdMaterial { get; set; }

        public virtual Material IdMaterialNavigation { get; set; }
        public virtual Monument IdMonumentNavigation { get; set; }
    }
}
