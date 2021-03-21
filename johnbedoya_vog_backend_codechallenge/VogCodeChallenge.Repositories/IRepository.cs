using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.Repositories
{

    public interface IRepository<T> where T : class
    {   
        IEnumerable<T> GetData();        
    }
}
