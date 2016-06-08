using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedNotes.Domain
{
    public class NotesRepository : INoteRepository
    {
        private readonly WorkSpaceContext _dbContext = new WorkSpaceContext();

        public void AddNote(Note note)
        {
            _dbContext.Notes.Add(note);
        }

        public Note GetNoteById(Guid id)
        {
            return _dbContext.Notes.FirstOrDefault(note => note.Id.Equals(id));
        }

        public void DeleteNote(Note note)
        {
            _dbContext.Notes.Remove(note);
        }

        public List<Note> GetAllNotes()
        {
            return _dbContext.Notes.ToList();
        }
    }
}
