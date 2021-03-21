using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {   
        public IEnumerable<Employee> GetAll()
        {
            return base.GetData();
        }

        public IList<Employee> ListAll()
        {
            return base.GetData().ToList();
        }
    }
}
