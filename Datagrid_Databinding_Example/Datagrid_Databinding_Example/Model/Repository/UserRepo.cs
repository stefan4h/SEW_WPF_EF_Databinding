using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datagrid_Databinding_Example.Model;

namespace Datagrid_Databinding_Example.Model.Repository
{
    public class UserRepo:BaseRepo<User>
    {
        private static UserRepo repo;

        public static UserRepo GetInstance()
        {
            return repo ?? (repo=new UserRepo());
        }

        public UserRepo()
        {
            Table = Context.Users;
        }
    }
}
