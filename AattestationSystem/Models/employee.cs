using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AattestationSystem.Models
{
    public class Employee : ApplicationDbContext
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}