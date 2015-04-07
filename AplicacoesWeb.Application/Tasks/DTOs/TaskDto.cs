using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AplicacoesWeb.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacoesWeb.Tasks.DTOs
{
    public class TaskDto : EntityDto
    {
        public int? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public byte State { get; set; }
    }
}
