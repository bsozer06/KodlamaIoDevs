﻿using Core.Application.Requests;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Commands.CreateProgramingLanguage;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Commands.UpdateProgramingLanguage;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Queries.GetByIdProgrammingLanguage;
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


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProgrammingLanguageQuery getByIdProgrammingLanguageQuery)
        {
            var result = await Mediator.Send(getByIdProgrammingLanguageQuery);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProgrammingLanguageCommand createProgrammingLanguageCommand)
        {
            var result = await Mediator.Send(createProgrammingLanguageCommand);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProgrammingLanguageCommand updateProgrammingLanguageCommand)
        {
            var result = await Mediator.Send(updateProgrammingLanguageCommand);
            return NoContent();
        }

    }
}
