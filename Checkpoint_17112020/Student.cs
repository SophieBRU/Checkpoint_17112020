using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint_17112020
{
    class Student
    {
        public Guid StudentId { get; set; }
        public String Lastname { get; set; }
        public String Firstname { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
