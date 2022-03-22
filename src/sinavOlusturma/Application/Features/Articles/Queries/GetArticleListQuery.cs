using Application.Features.Articles.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Queries
{
    public class GetArticleListQuery : IRequest<ArticleListModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetArticleListQueryHandler : IRequestHandler<GetArticleListQuery, ArticleListModel>
        {
            IArticleRepository _articleRepository;
            IMapper _mapper;

            public GetArticleListQueryHandler(IArticleRepository articleRepository, IMapper mapper)
            {
                _articleRepository = articleRepository;
                _mapper = mapper;
            }

            public async Task<ArticleListModel> Handle(GetArticleListQuery request, CancellationToken cancellationToken)
            {
                var articles = await _articleRepository.GetListAsync(index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize);
                var mappedArticle = _mapper.Map<ArticleListModel>(articles);
                return mappedArticle;
            }
        }
    }
}
