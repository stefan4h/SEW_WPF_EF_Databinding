using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datagrid_Databinding_Example.Model;
using Datagrid_Databinding_Example.Model.Repository;

namespace Datagrid_Databinding_Example
{
    class CustomInitializer: DropCreateDatabaseIfModelChanges<ContextClass>
    {
        protected override void Seed(ContextClass context)
        {
            List<User> users=new List<User>()
            {
                new User(){BirthDate = DateTime.Today,Email = "b.adams@gmail.com",FirstName = "Baker",LastName = "Adams",UserName = "badams"},
                new User(){BirthDate = DateTime.Today,Email = "c.davis@gmail.com",FirstName = "Clark",LastName = "Davis",UserName = "cavis"},
                new User(){BirthDate = DateTime.Today,Email = "e.frank@gmail.com",FirstName = "Evans",LastName = "Frank",UserName = "frevans"},
                new User(){BirthDate = DateTime.Today,Email = "g.hills@gmail.com",FirstName = "Ghosh",LastName = "Hills",UserName = "gills"},
                new User(){BirthDate = DateTime.Today,Email = "i.jones@gmail.com",FirstName = "Irwin",LastName = "Jones",UserName = "jirwin"},
                new User(){BirthDate = DateTime.Today,Email = "k.lopez@gmail.com",FirstName = "Klein",LastName = "Lopez",UserName = "klopez"},
                new User(){BirthDate = DateTime.Today,Email = "m.nalty@gmail.com",FirstName = "Mason",LastName = "Nalty",UserName = "malty"},
                new User(){BirthDate = DateTime.Today,Email = "o.patel@gmail.com",FirstName = "Ochoa",LastName = "Patel",UserName = "opatel"},
                new User(){BirthDate = DateTime.Today,Email = "q.reily@gmail.com",FirstName = "Quinn",LastName = "Reily",UserName = "queilly"},
                new User(){BirthDate = DateTime.Today,Email = "s.trott@gmail.com",FirstName = "Smith",LastName = "Trott",UserName = "schrott"},
                new User(){BirthDate = DateTime.Today,Email = "u.valdo@gmail.com",FirstName = "Usman",LastName = "Valdo",UserName = "uvaldo"},
            };
            UserRepo.GetInstance().AddRange(users);
        }
    }
}
