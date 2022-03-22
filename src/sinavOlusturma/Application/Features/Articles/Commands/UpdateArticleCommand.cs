using Application.Features.Articles.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Commands
{
    public class UpdateArticleCommand : IRequest<ArticleDto>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }

        public class UpdateArticleHandler : IRequestHandler<UpdateArticleCommand, ArticleDto>
        {
            private IArticleRepository _articleRepository;
            private IMapper _mapper;
      

            public UpdateArticleHandler(IArticleRepository articleRepository, IMapper mapper)
            {
                _articleRepository = articleRepository;
                _mapper = mapper;
            }

            public async Task<ArticleDto> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
            {
                var article = await _articleRepository.GetAsync(c => c.Id == request.Id);
                if (article == null)
                    throw new BusinessException("Article cannot found");
                
              
                _mapper.Map(request, article);

                await _articleRepository.UpdateAsync(article);
                return _mapper.Map<ArticleDto>(article);
            }
        }
    }
}
