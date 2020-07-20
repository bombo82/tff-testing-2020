using Notes.Repository;
using System;
using System.Collections.Generic;

namespace Notes.Service
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;
        private IClock clock;

        internal NotesService(INotesRepository repository)
        {
            this.repository = repository;
            this.clock = new Clock();
        }

        public NotesService(INotesRepository repository, IClock clock) : this(repository)
        {
            this.clock = clock;
        }

        public void Add(string titol, string description)
        {
            Note note = new Note(titol, description, clock.Now());
            repository.Insert(note);
        }

        public IList<Note> All()
        {
            return repository.All();
        }

        public void RemoveAll()
        {
        }
    }
}
