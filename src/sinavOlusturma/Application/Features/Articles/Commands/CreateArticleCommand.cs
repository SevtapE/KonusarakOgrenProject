using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Commands
{
    public class CreateArticleCommand : IRequest<Article>
    {

        public string Title { get; set; }
        public string ArticleText { get; set; }

        public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, Article>
        {
            private IArticleRepository _articleRepository;
            private IMapper _mapper;
      

            public CreateArticleCommandHandler(IArticleRepository articleRepository, IMapper mapper)
            {
                _articleRepository = articleRepository;
                _mapper = mapper;
            }

            public async Task<Article> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
            {
           
                var mappedArticle = _mapper.Map<Article>(request);
                var article =  await _articleRepository.AddAsync(mappedArticle);
                return article;
            }
        }
    }
}
