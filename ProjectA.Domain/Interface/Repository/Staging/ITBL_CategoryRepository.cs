using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.DB;
using ProjectA.Domain.ViewModel;

namespace ProjectA.Domain.Interface.Repository.Staging
{
    /// <summary>
    /// public interface InterfaceName : InterfaceBaseRepository<TableName>
    /// </summary>
    public interface ITBL_CategoryRepository : IBaseRepository<Category>
    {
        IEnumerable<Category> GetAllCategory();
        IQueryable<CategoryViewModel> GetById(string id);
    }
}
