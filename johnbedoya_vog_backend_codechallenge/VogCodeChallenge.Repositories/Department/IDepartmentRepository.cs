using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        IList<Department> ListAll();
    }
}
