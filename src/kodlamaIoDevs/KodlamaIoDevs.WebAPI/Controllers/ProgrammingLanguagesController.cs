﻿using Core.Application.Requests;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Queries.GetListProgrammingLanguage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIoDevs.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguagesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var getProgramLangListQuery = new GetListProgrammingLanguageQuery() { PageRequest = pageRequest };
            var result = await Mediator.Send(getProgramLangListQuery);
            return Ok(result);
        }
    }
}
