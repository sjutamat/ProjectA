using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjectA.DB;
using ProjectA.Domain.Interface.Repository.Staging;
using ProjectA.Domain.ViewModel;
using System.Linq.Expressions;

namespace ProjectA.DAL.Implement.Staging
{
    public class TBL_CategoryRepository : BaseRepository<Category>, ITBL_CategoryRepository
    {
        private readonly ProjectAEntities1 _ProjectAEntity;
        public TBL_CategoryRepository(ProjectAEntities1 _Context) : base(_Context)
        {
            _ProjectAEntity = _Context;
        }
   

        public IEnumerable<Category> GetAllCategory()
        {
            var data = All();
            return data;
        }

        public IQueryable<CategoryViewModel> GetById(string id)
        {
            var data = Filter(c => c.ID == id).AsNoTracking()
                   .Select(s => new CategoryViewModel()
                   {
                       id = s.ID,
                       name = s.Name,
                       updated_by = s.UpdatedBy,
                       updated_date = s.UpdatedDate.Value.ToString("dd/MM/yyyy")
                   }).OrderByDescending(o => o.name);
            return data;
        }
    }

}
