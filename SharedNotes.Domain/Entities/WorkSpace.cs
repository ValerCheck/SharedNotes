using System;
using System.ComponentModel.DataAnnotations;

namespace SharedNotes.Domain.Entities
{
    public class WorkSpace
    {
        [Required(ErrorMessage = "Please specify your workspace name")]
        public string Name { get; set; }
        public string Hash { get; set; }
        public Guid Id { get; set; }
    }
}