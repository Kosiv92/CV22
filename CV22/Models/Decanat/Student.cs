﻿using System;
using System.Collections.Generic;

namespace CV22.Models.Decanat
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }

    }

    internal class Group
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get;set; }
    }
}
