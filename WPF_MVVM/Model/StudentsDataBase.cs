using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Model
{
    internal class StudentsDataBase 
    {
        private static List<Student> students = new List<Student>
        {
            new Student(1, "Василий", "Пупкин", 18, 10.1),
            new Student(2, "Петр", "Бубкин", 17, 10.3),
            new Student(3, "Александр", "Мамонов", 19, 11),
            new Student(4, "Олег", "Скрипка", 20, 9.4),
            new Student(5, "Сергей", "Бобров", 18, 8.7)
        };

        public static List<Student> Students { get { return students; } set { students = value; } }

        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public static List<Student> GetAllStudents() => Students;
    }
}
