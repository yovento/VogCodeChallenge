using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public class DatabaseData
    {
        public static void Initialize(VogCodeChallengeDbContext _context)
        {

            if (_context.Departments.Any())
            {
                return;
            }

            _context.Departments.AddRange(
                new Department { address = "7432 Foster Street", name = "Design" },
                new Department { address = "63 Middle River Lane", name = "Development" },
                new Department { address = "Eden Prairie, MN 55347", name = "Human Resources" }
            );

            if (_context.Employees.Any())
            {
                return;
            }

            _context.Employees.AddRange(
                new Employee { departmentId = 1, firstName = "Colby", lastName = "Crosby", jobTitle = "UI/UX Designer", address = "1 Berkshire Ave. Forney, TX 75126" },
                new Employee { departmentId = 2, firstName = "Paul", lastName = "Barker", jobTitle = "Tech Lead", address = "1 Center Street New Bern, NC 28560" },
                new Employee { departmentId = 2, firstName = "Cristina", lastName = "Moses", jobTitle = ".Net Senior Developer", address = "594 Iroquois Court Bridgeton, NJ 08302" },
                new Employee { departmentId = 3, firstName = "Hadley", lastName = "Stephenson", jobTitle = "HR Representative", address = "8672 Liberty Drive Antioch, TN 37013" }
            );

            _context.SaveChanges();
        }
    }
}
