using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager_WPF.Models
{
    public class Student : INotifyPropertyChanged
{
    private string _username;
    private string _address;
    private int _age;

    public Student(string username, string address, int age)
    {
        Username = username;
        Address = address;
        Age = age;
    }
        public string Username
    {
        get => _username;
        set
        {
            if (_username != value)
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            if (_address != value)
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (_age != value)
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

}
