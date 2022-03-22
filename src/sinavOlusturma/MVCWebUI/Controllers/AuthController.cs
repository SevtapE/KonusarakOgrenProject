using Application.Features.Users.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebUI.Controllers
{
    public class AuthController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            RegisterUserCommand registerUserCommand=new RegisterUserCommand();
            return View(registerUserCommand);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserCommand registerUserCommand)
        {
            var result = await Mediator.Send(registerUserCommand);
            return View();
        }

   
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            LoginUserCommand loginUser=new LoginUserCommand();
            return View(loginUser);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserCommand loginUserCommand)
        {
            var result = await Mediator.Send(loginUserCommand);
            Console.WriteLine(result);
            return View();
        }
    }
}
