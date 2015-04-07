using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacoesWeb.Tasks.DTOs
{
    public class CreateTaskInput : IInputDto, ICustomValidate
    {
        public int? AssignedPersonId { get; set; }

        public bool SendEmailToAssignedPerson { get; set; }

        [Required]
        public string Description { get; set; }

        public void AddValidationErrors(List<ValidationResult> results)
        {
            if (SendEmailToAssignedPerson && (!AssignedPersonId.HasValue || AssignedPersonId.Value <= 0))
            {
                results.Add(new ValidationResult("AssignedPersonId must be set if SendEmailToAssignedPerson is true!"));
            }
        }
    }
}
