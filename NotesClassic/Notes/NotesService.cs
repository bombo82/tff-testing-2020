using Notes.Repository;
using System;

namespace Notes.Service
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;

        public NotesService(INotesRepository repository)
        {
            this.repository = repository;
        }

        public void Add(string titol, string description)
        {
            Note note = new Note(titol, description);
            repository.Insert(note);
        }
    }
}
