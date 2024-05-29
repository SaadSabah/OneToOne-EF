using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_EF
{
    internal class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public double CourseKredit { get; set; }
        public int CourseGrade { get; set;}
        public int StudentId { get; set; }
        public Students Student { get; set; }
    }
}
