using System;
using System.Linq;
using StudentManager_WPF.Models;
using StudentManager_WPF.ViewModels;

namespace StudentManager_WPF.Commands
{
    internal class SaveStudentInfoCommand : CommandBase
    {

        public override void Execute(object? parameter)
        {
            {
                EditStudentViewModel studentViewModel = (EditStudentViewModel)parameter;
                StudentViewModelManager.Instance.EditStudent(
                    studentViewModel.Student.Username, 
                    studentViewModel.StudentDummyData.Name, 
                    studentViewModel.StudentDummyData.City, 
                    studentViewModel.StudentDummyData.Age
                );
            }
        }
    }
}
