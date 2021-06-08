using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class CategoryPhoto
    {
        public CategoryPhoto()
        {
            Photos = new HashSet<Photo>();
        }

        public long IdCategoryPhoto { get; set; }
        public string Name { get; set; }
        public DateTime? CreatePhotoPhoto { get; set; }
        public DateTime? UpdateCategoryPhoto { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
