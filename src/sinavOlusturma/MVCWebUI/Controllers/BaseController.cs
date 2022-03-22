using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebUI.Controllers
{
    public class BaseController : Controller
    {

        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());

    }
}
