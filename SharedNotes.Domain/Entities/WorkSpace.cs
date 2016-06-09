using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedNotes.Domain.Entities
{
    public class WorkSpace
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please specify your workspace name")]
        public string Name { get; set; }
        public string Hash { get; set; }
    }
}