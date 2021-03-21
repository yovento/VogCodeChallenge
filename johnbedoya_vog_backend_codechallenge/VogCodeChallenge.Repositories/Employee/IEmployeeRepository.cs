using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
