using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Model
{
    internal class Teacher:BaseEntity
    {
        public int Age { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Subject  { get; set; }

    } 
}
