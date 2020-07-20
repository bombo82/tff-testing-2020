using Notes.Clock;
using System;
using System.Collections.Generic;

namespace Notes.Service
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;
        private IClock clock;

        public NotesService(INotesRepository repository, IClock clock)
        {
            this.repository = repository;
            this.clock = clock;
        }

        public void Add(string title, string description)
        {
            Note note = new Note(title, description, clock.Now());
            repository.Insert(note);
        }

        public IList<Note> All()
        {
            return repository.FindAll();
        }
    }
}
