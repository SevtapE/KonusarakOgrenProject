﻿using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ArticleRepository : EfRepositoryBase<Article, BaseDbContext>, IArticleRepository
    {
        public ArticleRepository(BaseDbContext context) : base(context)
        {
        }
    }
}