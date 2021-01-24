using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Timesheet_App_Bachelor_Thesis.Shared.Models;

namespace Timesheet_App_Bachelor_Thesis.Shared.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options)
           : base(options)
        {
        }
        //public DbSet<UsersAcc> UsersAccount { get; set; }
    }
}
