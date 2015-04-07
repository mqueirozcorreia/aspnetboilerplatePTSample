using Abp.Application.Services;
using AplicacoesWeb.People.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacoesWeb.Tasks
{
    public interface IPersonAppService : IApplicationService
    {
        GetAllPeopleOutput GetAllPeople();
    }
}
