using Abp.Application.Services.Dto;
using AplicacoesWeb.People.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacoesWeb.People.DTOs
{
    public class GetAllPeopleOutput : IOutputDto
    {
        public List<PersonDto> People { get; set; }
    }
}
