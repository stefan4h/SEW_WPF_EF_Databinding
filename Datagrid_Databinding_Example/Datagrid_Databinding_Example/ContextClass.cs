using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datagrid_Databinding_Example.Model;

namespace Datagrid_Databinding_Example
{
    public class ContextClass:DbContext
    {
        public DbSet<User> Users { get; set; }

        private static ContextClass context;
        public static ContextClass GetInstance()
        {
            return context ?? (context = new ContextClass());
        }

        public ContextClass() : base("Datagrid_Example")
        {
            Database.SetInitializer(new CustomInitializer());
            Database.Initialize(true);
        }
    }
}
