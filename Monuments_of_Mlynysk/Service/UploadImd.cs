using Monuments_of_Mlynysk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace Monuments_of_Mlynysk.Service
{
    public class UploadImd
    {
        [HttpGet]
        public static object uploadImdSingle() { 
             using (MonumentDBContext db = new MonumentDBContext()){

                var photo = from photos in db.Photos
                                join category in db.CategoryPhotos on photos.IdCategoryPhoto equals category.IdCategoryPhoto
                                where category.IdCategoryPhoto == 1
                                select new { photos.Name,photos.PathFull, photos.PathMini, photos.Uuid, types = category.Name };
                object photoUpload = photo.ToList();           
                return photoUpload;
            }
        }
        [HttpGet]
        public static object uploadImdDual()
        {
            using (MonumentDBContext db = new MonumentDBContext())
            {

                var photo = from photos in db.Photos
                            join category in db.CategoryPhotos on photos.IdCategoryPhoto equals category.IdCategoryPhoto
                            where category.IdCategoryPhoto == 2
                            select new { photos.Name, photos.PathFull, photos.PathMini, photos.Uuid, types = category.Name };
                object photoUpload = photo.ToList();
                return photoUpload;
            }
        }
        [HttpGet]
        public static object uploadImdElite()
        {
            using (MonumentDBContext db = new MonumentDBContext())
            {

                var photo = from photos in db.Photos
                            join category in db.CategoryPhotos on photos.IdCategoryPhoto equals category.IdCategoryPhoto
                            where category.IdCategoryPhoto == 3
                            select new { photos.Name, photos.PathFull, photos.PathMini, photos.Uuid, types = category.Name };
                object photoUpload = photo.ToList();
                return photoUpload;
            }
        }
    }

}
