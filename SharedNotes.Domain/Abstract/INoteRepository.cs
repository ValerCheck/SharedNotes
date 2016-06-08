using System;
using System.Collections.Generic;
using SharedNotes.Domain.Entities;

namespace SharedNotes.Domain.Abstract
{
    public interface INoteRepository
    {
        void AddNote(Note note);
        void DeleteNote(Note note);
        Note GetNoteById(Guid id);
        List<Note> GetAllNotes();
    }
}
