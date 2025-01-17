using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StudentManager_WPF.Commands;
using StudentManager_WPF.Stores;

namespace StudentManager_WPF.ViewModels
{
    class StudentInformationViewModel : ViewModelBase
    {
        public StudentInfoDetailsViewModel StudentInfoDetailsViewModel { get; }

        public StudentListingViewModel StudentListingViewModel { get; }    
        public ICommand AddStudentCommand { get;}

        public StudentInformationViewModel(SelectedStudentStore _selectedStudentStore)
        {
            StudentListingViewModel = new StudentListingViewModel(_selectedStudentStore);
            StudentInfoDetailsViewModel = new StudentInfoDetailsViewModel(_selectedStudentStore);

            AddStudentCommand = new AddStudentInfoCommand();
        }
    }
}
