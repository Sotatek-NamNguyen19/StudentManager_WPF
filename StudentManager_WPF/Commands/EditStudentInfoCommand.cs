using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager_WPF.Components;
using StudentManager_WPF.Models;

namespace StudentManager_WPF.Commands
{
    internal class EditStudentInfoCommand : CommandBase
    {
        public EditStudentInfoCommand() { }
        public override void Execute(object? parameter)
        {
            if (parameter is Student student)
            {
                var viewModel = new EditStudentViewModel(student);
                var editWindow = new EditStudentWindow
                {
                    DataContext = viewModel
                };
                editWindow.ShowDialog();
            }
        }
    }
}
