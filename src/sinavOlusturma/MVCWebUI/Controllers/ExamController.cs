using Application.Features.Exams.Commands;
using Application.Features.Exams.Queries;
using Core.Application.Requests;
using Infrastructure.OutServices.MyContentHelper;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebUI.Controllers
{
    public class ExamController : BaseController
    {
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var query = new GetExamListQuery();
            query.PageRequest = pageRequest;
            var result = await Mediator.Send(query);

            //ContentHelper contentHelper = new ContentHelper();
            //contentHelper.GetTitle();
           
            return View(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteExamCommand deleteExamCommand)
        {
            var result = await Mediator.Send(deleteExamCommand);
            return View();
        }
    }
}
