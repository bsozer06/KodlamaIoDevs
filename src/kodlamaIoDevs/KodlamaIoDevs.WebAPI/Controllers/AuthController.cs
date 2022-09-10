using KodlamaIoDevs.Application.Features.UserApp.Commands.RegisterUserApp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIoDevs.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        [HttpPost(nameof(Register))]
        public async Task<ActionResult> Register([FromBody] RegisterUserAppCommand registerUserAppCommand)
        {
            var result = await Mediator!.Send(registerUserAppCommand);
            return Ok(result);
        }
    }
}
