using System;
using System.ComponentModel.DataAnnotations;

namespace SharedNotes.Domain.Entities
{
    public class WorkSpaceNotes
    {
        [Key]
        public Guid Id { get; set; }
        public Guid WorkSpaceId { get; set; }
        public Guid NoteId { get; set; }
    }
}
