using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Domain;

namespace VogCodeChallenge.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected VogCodeChallengeDbContext _dbContext;
        protected DbSet<T> DbSet;
        public BaseRepository(VogCodeChallengeDbContext dbContext)
        {
            _dbContext = dbContext;
            DbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetData()
        {   
            return DbSet;
        }
    }
}
