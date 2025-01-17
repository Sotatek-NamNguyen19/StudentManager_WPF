using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager_WPF.Models;

namespace StudentManager_WPF.Stores
{
    public class SelectedStudentStore
    {

        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }
            set
            {
                _selectedStudent = value;
                SelectedStudentChanged?.Invoke();
            }
        }
        public event Action SelectedStudentChanged;

    }
}
