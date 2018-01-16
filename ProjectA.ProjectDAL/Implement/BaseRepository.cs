using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Op3ration.RepositoryHandler;

namespace ProjectA.ProjectDAL.Implement
{
    public class BaseRepository<T> : Repositories<T> where T : class
    {
        public BaseRepository(DbContext _Context) : base(_Context)
        {
            _Context.Configuration.ProxyCreationEnabled = false;
            _Context.Configuration.LazyLoadingEnabled = false;
        }
    }
    
}
