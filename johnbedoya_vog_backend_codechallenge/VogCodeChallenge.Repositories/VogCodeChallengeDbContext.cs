using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public class VogCodeChallengeDbContext : DbContext
    {
        public VogCodeChallengeDbContext(DbContextOptions<VogCodeChallengeDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
