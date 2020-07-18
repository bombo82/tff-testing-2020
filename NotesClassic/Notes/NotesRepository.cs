using Notes.Repository;
using Notes.Service;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Notes.UnitTest.Repository
{
    public class NotesRepository : INotesRepository
    {
        public List<Note> notes = new List<Note>();

        public void Insert(Note note)
        {
            notes.Add(note);
        }
    }
}
