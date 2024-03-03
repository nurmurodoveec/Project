using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class UsersDbContext : DbContext
    {
        public virtual DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        { 
            optionBuilder.UseSqlServer("Data Source=WIN-68JTTU6BA4D\\MSSQLSERVER01;Initial Catalog=Users1;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False");
            base.OnConfiguring(optionBuilder);
        }
    }
}
