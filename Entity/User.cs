﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        public int Id { get; set; }

        public string? Surname { get;set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public string? Group { get; set; }
    }
}
