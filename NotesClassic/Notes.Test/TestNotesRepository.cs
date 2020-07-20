using Notes.Service;
using System.Collections.Generic;

namespace Notes.UnitTest.Service
{
    internal class TestNotesRepository : INotesRepository
    {
        public IList<Note> notes = new List<Note>();

        public IList<Note> FindAll()
        {
            return notes;
        }

        public void Insert(Note note)
        {
            notes.Add(note);
        }
    }
}