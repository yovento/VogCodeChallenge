using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public class BaseRepository<T> where T : class
    {
        protected IEnumerable<T> _exampleData;
        protected VogCodeChallengeDbContext _dbContext = new VogCodeChallengeDbContext();
        protected DbSet<T> DbSet;

        public BaseRepository()
        {
            DbSet = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetData()
        {   
            return DbSet;
        }
    }
}
