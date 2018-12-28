using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Model
{
    public class Student
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
