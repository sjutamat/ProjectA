﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjectA.DB;
using ProjectA.Domain.Interface.Repository.Staging;
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


    }

}