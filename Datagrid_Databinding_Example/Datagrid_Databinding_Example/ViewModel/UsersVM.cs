using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Datagrid_Databinding_Example.Model;
using Datagrid_Databinding_Example.Model.Repository;
using Datagrid_Databinding_Example.View;

namespace Datagrid_Databinding_Example.ViewModel
{
    public class UsersVM : AViewModel
    {
        private UserVM _user;
        public UserVM User
        {
            get => _user;
            set
            {
                if(value==_user)return;
                _user = value;
                OnPropertyChanged();
            }
        }

        private readonly UserRepo _repo = UserRepo.GetInstance();

        public ObservableCollection<UserVM> Users { get; set; } = new ObservableCollection<UserVM>();

        public UsersVM()
        {
            _repo.GetAll().ForEach(u => Users.Add(new UserVM(u)));
            User = null;
        }

        public ICommand RemoveUserCommand
        {
            get { return new RelayCommand(o => DeleteUser(), o => User!=null); }
        }

        private void DeleteUser()
        {
            _repo.Delete(User.User);
            Users.Remove(User);
        }

        public ICommand OpenCreateUserViewCommand
        {
            get { return new RelayCommand(o => ShowCreateUserView(), o => true); }
        }

        private void ShowCreateUserView()
        {
            User = new UserVM(new User());
            var createUserView = new CreateUserView {DataContext = this};
            createUserView.ShowDialog();
            User = null;
        }

        public ICommand CreateUserCommand
        {
            get { return new RelayCommand(o => CreateUser(), o => true); }
        }

        private void CreateUser()
        {
            var u = new User
            {
                FirstName = User.FirstName,
                LastName = User.LastName,
                UserName = User.UserName,
                Email = User.Email,
                BirthDate = User.BirthDate
            };
            _repo.Add(u);
            Users.Add(new UserVM(_repo.GetOne(u.UserId)));
            User = null;
        }

        public ICommand OpenUpdateUserViewCommand
        {
            get { return new RelayCommand(o => ShowUpdateUserView(), o => User!=null); }
        }

        private void ShowUpdateUserView()
        {
            var updateUserView = new UpdateUserView() {DataContext = this};
            updateUserView.ShowDialog();
        }

        public ICommand UpdateUserCommand
        {
            get { return new RelayCommand(o => UpdateUser(), o => true); }
        }

        private void UpdateUser()
        {
            var u = User.User;
            _repo.Save(u);
            User = null;
        }

        public ICommand OpenUserViewCommand
        {
            get { return new RelayCommand(o => ShowUserView(), o => User != null); }
        }

        private void ShowUserView()
        {
            var userView = new UserView() { DataContext = this };
            userView.ShowDialog();
        }
    }
}