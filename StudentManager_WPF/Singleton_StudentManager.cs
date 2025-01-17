using System.Collections.ObjectModel;
using System.Net;
using StudentManager_WPF.Models;
using StudentManager_WPF.ViewModels;

public class StudentViewModelManager
{
    private static StudentViewModelManager _instance;
    public static StudentViewModelManager Instance => _instance ?? (_instance = new StudentViewModelManager());

    public ObservableCollection<StudentListingItemViewModel> StudentViewModels { get; set; }

    private StudentViewModelManager()
    {
        StudentViewModels = new ObservableCollection<StudentListingItemViewModel>
        {
            //CREATE DUMMY DATA
            new StudentListingItemViewModel(new Student("Alice", "CityA", 20)),
            new StudentListingItemViewModel(new Student("Bob", "CityB", 22)),
            new StudentListingItemViewModel(new Student("Charlie", "CityC", 23))
        };
    }
    public void DeleteStudent(string username, int age, string address)
    {
        var studentToDelete = StudentViewModels.FirstOrDefault(s =>
            s.Student.Username == username &&
            s.Student.Age == age &&
            s.Student.Address == address);

        if (studentToDelete != null)
        {
            StudentViewModels.Remove(studentToDelete);
        }
    }


    public void EditStudent(string username, string newName,string newAddress, int newAge)
    {
        var studentToEdit = StudentViewModels.FirstOrDefault(s => s.Student.Username == username);
        if (studentToEdit != null)
        {
            studentToEdit.Student.Username = newName;
            studentToEdit.Student.Address = newAddress;
            studentToEdit.Student.Age = newAge;
        }
    }
}
