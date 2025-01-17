using System.Windows.Input;
using StudentManager_WPF.ViewModels;

namespace StudentManager_WPF.Commands
{
    internal class DeleteStudentInfoCommand : CommandBase
    {
        public DeleteStudentInfoCommand() { }

        public override void Execute(object? parameter)
        {
            if (parameter is StudentListingItemViewModel studentViewModel)
            {
                var students = StudentViewModelManager.Instance.StudentViewModels;
                students.Remove(studentViewModel);
            }
        }
    }
}
