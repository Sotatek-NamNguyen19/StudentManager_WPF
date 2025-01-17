using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager_WPF.Models;
using StudentManager_WPF.Stores;

namespace StudentManager_WPF.ViewModels
{
    public class StudentListingViewModel : ViewModelBase
    {
        private readonly SelectedStudentStore _selectedStudentStore;
        public ObservableCollection<StudentListingItemViewModel> _studentListingItemViewModels => StudentViewModelManager.Instance.StudentViewModels;
        public IEnumerable<StudentListingItemViewModel> StudentListingItemViewModels => _studentListingItemViewModels;

        private StudentListingItemViewModel _selectedStudentListingItemViewModel;

        public StudentListingItemViewModel SelectedStudentListingItemViewModel
        {
            get
            {
                return _selectedStudentListingItemViewModel;
            } 
            set
            {
                _selectedStudentListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedStudentListingItemViewModel));

                _selectedStudentStore.SelectedStudent = _selectedStudentListingItemViewModel.Student;
            }
        }

        public StudentListingViewModel(SelectedStudentStore selectedStudentStore)
        {
            _selectedStudentStore = selectedStudentStore;
            //Create some dummy data
            _studentListingItemViewModels.Add(new StudentListingItemViewModel(new Student("Dong", "Hanoi", 33)));
            _studentListingItemViewModels.Add(new StudentListingItemViewModel(new Student("Tay", "SaiGon", 24)));
            _studentListingItemViewModels.Add(new StudentListingItemViewModel(new Student("Nam", "HCM", 40))); 
            _studentListingItemViewModels.Add(new StudentListingItemViewModel(new Student("Bac", "Thanh Hoa", 44)));
        }
    }
}
