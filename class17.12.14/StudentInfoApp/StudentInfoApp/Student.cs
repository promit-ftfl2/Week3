using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Student
    {
        public string regno;
        public string firstname;
        public string lastname;

        public string GetFullName()
        {
            return firstname + " " + lastname;
        }
    }
}
