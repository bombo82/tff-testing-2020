using System;

namespace Notes.Service
{
    public class NotesService : INoteService
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
            repository.Insert(new Note(title, description, clock.Now()));
        }
    }
}
