using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM.Model;

namespace WPF_MVVM.ViewModel
{
    internal class StudentViewModel : INotifyPropertyChanged
    {
        List<Student> students;

        public StudentViewModel()
        {
            students = new List<Student>
            {
                new Student(1, "Василий", "Пупкин", 18, 10.1),
                new Student(1, "Петр", "Бубкин", 17, 10.3),
                new Student(1, "Александр", "Мамонов", 19, 11),
                new Student(1, "Олег", "Скрипка", 20, 9.4),
                new Student(1, "Сергей", "Бобров", 18, 8.7),
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanget([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
