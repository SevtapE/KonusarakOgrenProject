using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Rules
{
    public class ArticleBusinessRules
    {
        private IArticleRepository _articleRespository;

        public ArticleBusinessRules(IArticleRepository articleRespository)
        {
            _articleRespository = articleRespository;
        }


        
    }
}
