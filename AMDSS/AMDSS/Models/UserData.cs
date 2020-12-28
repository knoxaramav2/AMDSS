using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDSS.Models
{
    public class UserData
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } //Salt/Hash
        public int PhotoId { get; set; }
    }

    public class AdminData
    {
        public int Id { get; set; }

        public UserData AdminUser { get; set; }
    }

    public class AccountDB : DbContext
    {
        public AccountDB(DbContextOptions<AccountDB> options) : base (options)
        {

        }

        public DbSet<UserData> Users { get; set; }
        public DbSet<AdminData> Admins { get; set; }
    }
}
