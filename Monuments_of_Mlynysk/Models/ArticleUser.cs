using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class ArticleUser
    {
        public long IdArticle { get; set; }
        public long IdUser { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
