using Notes.Repository;
using Notes.Service;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Notes.UnitTest.Repository
{
    class TestNotesRepository : INotesRepository
    {
        public List<Note> notes = new List<Note>();

        public IList<Note> All()
        {
            return notes.ToImmutableList();
        }

        public void Insert(Note note)
        {
            notes.Add(note);
        }
    }
}
