using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_EF
{
    internal class Students
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public Courses Courses { get; set; }

    }
}
