using System;
using System.Collections.Generic;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class Worker
    {
        public Worker()
        {
            MonumentWorkers = new HashSet<MonumentWorker>();
        }

        public long IdWorker { get; set; }
        public string FirstName { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rete { get; set; }
        public decimal Salary { get; set; }
        public string LastName { get; set; }
        public DateTime? CreateWorcer { get; set; }
        public DateTime? UpdateWorker { get; set; }

        public virtual ICollection<MonumentWorker> MonumentWorkers { get; set; }
    }
}
