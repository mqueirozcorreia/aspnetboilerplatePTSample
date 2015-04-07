using Abp.Application.Services;
using AplicacoesWeb.Tasks.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacoesWeb.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);

        void UpdateTask(UpdateTaskInput input);

        void CreateTask(CreateTaskInput input);
    }
}
