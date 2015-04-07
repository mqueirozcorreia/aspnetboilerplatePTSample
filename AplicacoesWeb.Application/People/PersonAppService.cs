using Abp.Domain.Repositories;
using AplicacoesWeb.People;
using AplicacoesWeb.People.Dtos;
using AplicacoesWeb.People.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacoesWeb.Tasks
{
    public class PersonAppService : IPersonAppService //Optionally, you can derive from ApplicationService as we did for TaskAppService class.
    {
        private readonly IRepository<Person> _personRepository;

        //ABP provides that we can directly inject IRepository<Person> (without creating any repository class)
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public GetAllPeopleOutput GetAllPeople()
        {
            return new GetAllPeopleOutput
            {
                People = Mapper.Map<List<PersonDto>>(_personRepository.GetAllList())
            };
        }
    }
}
