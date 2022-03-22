using Application.Services.Repositories;
using Core.Application.Response;
using Core.CrossCuttingConcerns.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Commands
{
    public class DeleteArticleCommand : IRequest<NoContent>
    {
        public int Id { get; set; }

        public class DeleteArticleCommandHandler : IRequestHandler<DeleteArticleCommand, NoContent>
        {
            private IArticleRepository _articleRepository;

            public DeleteArticleCommandHandler(IArticleRepository articleRepository)
            {
                _articleRepository = articleRepository;
            }

            public async Task<NoContent> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
            {
                var article = await _articleRepository.GetAsync(c => c.Id == request.Id);
                if (article == null)
                    throw new BusinessException("Article not found");
                await _articleRepository.DeleteAsync(article);
                return new NoContent();
            }
        }
    }
}
