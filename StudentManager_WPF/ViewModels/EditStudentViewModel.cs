using System.Windows.Input;
using StudentManager_WPF.Models;
using StudentManager_WPF.Commands;
using StudentManager_WPF.ViewModels;
using System.Windows;

public class DataContainer
{
    public string Name { get; set; }
    public string City { get; set; }
    public int Age { get; set; }
}
public class EditStudentViewModel : ViewModelBase
{
    public DataContainer StudentDummyData{get;set;}
    public Student Student { get; private set; }

    public ICommand SaveCommand { get; }
    public ICommand CloseCommand { get; }

    public EditStudentViewModel(Student student)
    {
        Student = student;
        SaveCommand = new SaveStudentInfoCommand();

        StudentDummyData = new DataContainer
        {
        };
    }
}
