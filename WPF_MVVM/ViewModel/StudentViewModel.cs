using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM.Model;

namespace WPF_MVVM.ViewModel
{
    internal class StudentViewModel : INotifyPropertyChanged
    {
        public List<Student> Students { get; set; }

        private Student selectedStudent;

        private Commands addCommand;
        private Commands removeCommand;
        private Commands copyCommand;

        public StudentViewModel()// => students = StudentsDataBase.GetAllStudents();
        {
            Students = StudentsDataBase.GetAllStudents();
        }

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanget("SelectedStudent");
            }
        }

        public Commands AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new Commands(obj =>
                    {
                        Student student = new Student();
                        Students.Insert(0, student);
                        selectedStudent = student;
                    }));
            }
        }

        public Commands RemoveCommand
        {
            get
            {
                return removeCommand ?? (removeCommand = new Commands(obj => Students.Remove(selectedStudent)));
            }
        }

        public Commands CopyCommand
        {
            get
            {
                return copyCommand ??
                    (copyCommand = new Commands(obj =>
                    {
                        Student student = new Student(
                            selectedStudent.Id, selectedStudent.FirstName, selectedStudent.LastName, selectedStudent.Age, selectedStudent.GPA);
                        Students.Insert(0, student);
                        selectedStudent = student;
                    }));
            }
        }

        


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanget([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
