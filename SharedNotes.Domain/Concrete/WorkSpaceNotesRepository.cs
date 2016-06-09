using System;
using System.Collections.Generic;
using System.Linq;
using SharedNotes.Domain.Abstract;
using SharedNotes.Domain.Entities;

namespace SharedNotes.Domain.Concrete
{
    public class WorkSpaceNotesRepository : IWorkSpaceNotesRepository
    {
        private readonly WorkSpaceContext _dbContext = new WorkSpaceContext();

        public void AddNoteToWorkSpace(Note note, WorkSpace workspace)
        {
            _dbContext.NotesWorkSpace.Add(new WorkSpaceNotes()
            {
                Id = Guid.NewGuid(),
                NoteId = note.Id,
                WorkSpaceId = workspace.Id
            });
        }

        public void DeleteNoteFromWorkSpace(Note note, WorkSpace workspace)
        {
            var workSpaceNote = _dbContext.NotesWorkSpace.FirstOrDefault(
                x => x.NoteId == note.Id && 
                x.WorkSpaceId == workspace.Id);

            if (workSpaceNote == null) return;

            _dbContext.NotesWorkSpace.Remove(workSpaceNote);
        }
        
        public List<Note> GetAllNotesFromWorkSpace(WorkSpace workspace)
        {
            var query = from record in _dbContext.NotesWorkSpace
                        join note in _dbContext.Notes on record.NoteId equals note.Id
                        join ws in _dbContext.WorkSpaces on record.WorkSpaceId equals ws.Id
                        select note;
            return query.ToList();
        }
    }
}
