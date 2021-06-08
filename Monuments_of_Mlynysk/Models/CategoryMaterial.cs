using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class CategoryMaterial
    {
        public CategoryMaterial()
        {
            Materials = new HashSet<Material>();
        }

        public long IdCategoryMaterial { get; set; }
        public string Name { get; set; }
        public DateTime? CreateCategoryMaterial { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
