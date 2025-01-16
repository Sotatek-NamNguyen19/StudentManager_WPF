using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManager_WPF.ViewModels
{
    class StudentInformationViewModel : ViewModelBase
    {
        public StudentInfoDetailsViewModel StudentInfoDetailsViewModel { get; }

        public StudentListingViewModel StudentListingViewModel { get; }    
        public ICommand AddStudentCommand { get;}

        public StudentInformationViewModel()
        {
            StudentListingViewModel = new StudentListingViewModel();
            StudentInfoDetailsViewModel = new StudentInfoDetailsViewModel();    
        }
    }
}
