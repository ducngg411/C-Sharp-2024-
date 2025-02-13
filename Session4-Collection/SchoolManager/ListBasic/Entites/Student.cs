﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ListBasic.Entites
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString() => $"{Id} {Name} {Yob} {Gpa}";

        public void ShowProfile()
        {
            Console.WriteLine(ToString());
        }
    }
}
