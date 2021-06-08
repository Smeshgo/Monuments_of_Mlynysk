using Monuments_of_Mlynysk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monuments_of_Mlynysk.Service
{
    public class Article
    {
        public static object articlesUpload()
        {
            using (MonumentDBContext db = new MonumentDBContext())
            {

                var articles = from article in db.Articles
                            join photoArticles in db.PhotoArticles on article.IdArticle equals photoArticles.IdArticle 
                            join photo in db.Photos on photoArticles.IdPhoto equals photo.IdPhoto
                        select new { article.Title, article.Contents, photo.Name, photo.PathFull, photo.Uuid };

                object articleUpload = articles.ToList();
                return articleUpload;
            }
        }
    }
}
