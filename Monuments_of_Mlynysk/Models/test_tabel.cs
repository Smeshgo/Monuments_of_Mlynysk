using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Monuments_of_Mlynysk.Models
{
    public class test_tabel
    {
        [Key]
        public int did { get; set; }
        public DateTime date_prod { get; set; }
        public string title { get; set; }
        public string kind { get; set; }

    }
}
