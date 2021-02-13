﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CV19.Models.Decanat
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Brithday { get; set; }
        public double Rating { get; set; }
    }
    internal class Group
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
