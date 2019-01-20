using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datagrid_Databinding_Example.Model;

namespace Datagrid_Databinding_Example.ViewModel
{
    public class UserVM:AViewModel
    {
        public User User { get; }

        public UserVM(User user)
        {
            this.User = user;
        }

        public string FirstName
        {
            get => User.FirstName;
            set
            {
                User.FirstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => User.LastName;
            set
            {
                User.LastName = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => User.Email;
            set
            {
                User.Email = value;
                OnPropertyChanged();
            }
        }
        public string UserName
        {
            get => User.UserName;
            set
            {
                User.UserName = value;
                OnPropertyChanged();
            }
        }
        public DateTime BirthDate
        {
            get => User.BirthDate;
            set
            {
                User.BirthDate = value;
                OnPropertyChanged();
            }
        }
        public string FullName => User.FullName;
    }
}
