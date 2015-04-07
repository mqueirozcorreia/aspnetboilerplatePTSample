using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacoesWeb.Tasks.DTOs
{
    public class GetTasksInput : IInputDto
    {
        public int? AssignedPersonId { get; set; }

        public TaskState? State { get; set; }
    }
}
