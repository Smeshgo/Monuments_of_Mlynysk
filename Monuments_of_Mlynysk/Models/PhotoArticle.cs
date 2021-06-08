using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class PhotoArticle
    {
        public long IdPhoto { get; set; }
        public long IdArticle { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
        public virtual Photo IdPhotoNavigation { get; set; }
    }
}
