using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Model
{
    internal class Student : INotifyPropertyChanged
    {
        int id;
        string firstName;
        string lastName;
        int age;
        double gpa;

        public int Id
        { 
            get { return id; }
            set 
            { 
                id = value;
                OnPropertyChanget("Id");
            }
        }     

        public string FirstName 
        { 
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanget("FirstName");
            }
        }

        public string LastName 
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanget("LastName");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanget("Age");
            }
        }

        public double GPA
        { 
            get { return gpa; }
            set
            {
                gpa = value;
                OnPropertyChanget("GPA");
            }
        }

        public Student()
        {
            Id = 0;
            FirstName = null;
            LastName = null;
            Age = 0;
            GPA = 0;
        }

        public Student(int id, string firstName, string lastName, int age, double gPA)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            GPA = gPA;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanget([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
