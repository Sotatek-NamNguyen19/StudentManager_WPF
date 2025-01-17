using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager_WPF.Models;
using StudentManager_WPF.ViewModels;

namespace StudentManager_WPF.Commands
{
    internal class AddStudentInfoCommand : CommandBase
    {
        public AddStudentInfoCommand() { }
        public override void Execute(object? parameter)
        {
            var newStudent = new Student("New Student", "New City", 25);
            StudentViewModelManager.Instance.StudentViewModels.Add(new StudentListingItemViewModel(newStudent));
        }
    }
}
