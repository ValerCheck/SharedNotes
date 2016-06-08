using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedNotes.Domain
{
    public interface INoteRepository
    {
        void AddNote(Note note);
        void DeleteNote(Note note);
        Note GetNoteById(Guid id);
        List<Note> GetAllNotes();
    }
}
