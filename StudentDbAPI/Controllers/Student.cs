using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDbAPI.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MatricNo { get; set; }
    }
}
