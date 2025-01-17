using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StudentManager_WPF.Commands;
using StudentManager_WPF.Models;

namespace StudentManager_WPF.ViewModels
{
    public class StudentListingItemViewModel : ViewModelBase
    {
        private Student _student;

        public Student Student
        {
            get => _student;
            set
            {
                if (_student != value)
                {
                    if (_student != null)
                    {
                        _student.PropertyChanged -= OnStudentPropertyChanged;
                    }
                    _student = value;
                    if (_student != null)
                    {
                        _student.PropertyChanged += OnStudentPropertyChanged;
                    }
                    OnPropertyChanged(nameof(Student));
                }
            }
        }

        private void OnStudentPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName);
        }
        public string Username => Student.Username;    

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }

        public StudentListingItemViewModel(Student student)
        {
            Student = student;
            DeleteCommand = new DeleteStudentInfoCommand();
            EditCommand = new EditStudentInfoCommand();
        }
    }
}
