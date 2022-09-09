using Core.Application.Requests;
using KodlamaIoDevs.Application.Features.Technology.Queries.GetListTecnology;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIoDevs.WebAPI.Controllers
{
    public class TechnologiesController: BaseController
    {
        [HttpGet(nameof(GetList))]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var getTechnologyListQuery = new GetListTechnologyQuery() { PageRequest = pageRequest };
            var result = await Mediator!.Send(getTechnologyListQuery);
            return Ok(result);
        }
    }
}
