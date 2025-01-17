using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StudentManager_WPF.Stores;

namespace StudentManager_WPF.ViewModels
{
    class StudentInfoDetailsViewModel : ViewModelBase
    {
        private readonly SelectedStudentStore _selectedStudentStore;

        public bool HasSelectedStudent => _selectedStudentStore.SelectedStudent != null;
        public string Username => _selectedStudentStore.SelectedStudent?.Username ?? "Unknown";

        public string Address => _selectedStudentStore.SelectedStudent?.Address ?? "Unknown";

        public int Age => _selectedStudentStore.SelectedStudent?.Age ?? 0;

        public StudentInfoDetailsViewModel(SelectedStudentStore selectedStudentStore)
        {
            _selectedStudentStore = selectedStudentStore;

            _selectedStudentStore.SelectedStudentChanged += SelectedStudentStore_SelectedStudentChanged;
        }

        protected override void Dispose()
        {
            _selectedStudentStore.SelectedStudentChanged -= SelectedStudentStore_SelectedStudentChanged;

            base.Dispose();
        }
        private void SelectedStudentStore_SelectedStudentChanged()
        {
            OnPropertyChanged(nameof(HasSelectedStudent));

            OnPropertyChanged(nameof(Username));

            OnPropertyChanged(nameof(Address));

            OnPropertyChanged(nameof(Age));
        }
    }
}
