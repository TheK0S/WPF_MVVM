﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Model
{
    internal class Student : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        public Student(int id, string firstName, string lastName, int age, double gPA)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            GPA = gPA;
        }
    }
}
