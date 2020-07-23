using System;

namespace Notes.Service
{
    public class NotesService : INoteService
    {
        private INotesRepository repository;

        public NotesService(INotesRepository repository)
        {
            this.repository = repository;
        }

        public void Add(string title, string description)
        {
            repository.Insert(null);
        }
    }
}
