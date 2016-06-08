using System;
using System.ComponentModel.DataAnnotations;

namespace SharedNotes.Domain
{
    public class WorkSpace
    {
        [Required(ErrorMessage = "Please specify your workspace name")]
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}