﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDevs.Application.Features.Technology.Dtos
{
    public class CreatedTechnologyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgrammingLanguageId { get; set; }
    }
}
