using System.Collections.Generic;
using SharedNotes.Domain.Entities;

namespace SharedNotes.Domain.Abstract
{
    public interface IWorkSpaceNotesRepository
    {
        void AddNoteToWorkSpace(Note note,WorkSpace workspace);
        void DeleteNoteFromWorkSpace(Note note, WorkSpace workspace);
        List<Note> GetAllNotesFromWorkSpace(WorkSpace workspace);
    }
}
