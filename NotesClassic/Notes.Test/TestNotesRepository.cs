using Notes.Service;
using System.Collections.Generic;

namespace Notes.UnitTest.Service
{
    internal class TestNotesRepository : INotesRepository
    {
        public IList<Note> notes = new List<Note>();

        public void Insert(Note note)
        {
            notes.Add(note);
        }
    }
}