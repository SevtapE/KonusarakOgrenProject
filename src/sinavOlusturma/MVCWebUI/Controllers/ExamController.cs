using Application.Features.Exams.Commands;
using Application.Features.Exams.Queries;
using Core.Application.Requests;
using Infrastructure.OutServices.MyContentHelper;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models.ViewModels;

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

        [HttpGet]
        public async Task<IActionResult> CreateExam()
        {
            ExamViewModel examViewModel = new ExamViewModel();
            return View(examViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExam(ExamViewModel examViewModel)
        {
             await Mediator.Send(examViewModel.Article);
            await Mediator.Send(examViewModel.Questions);
            await Mediator.Send(examViewModel.Exam);
            return View();
        }
    }
}
