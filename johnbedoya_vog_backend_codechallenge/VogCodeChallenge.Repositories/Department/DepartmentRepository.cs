using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {   
        public IEnumerable<Department> GetAll()
        {
            return base.GetData();
        }

        public IList<Department> ListAll()
        {
            return base.GetData().ToList();
        }
    }
}
