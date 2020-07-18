﻿using Notes.Repository;
using System;
using System.Collections.Generic;

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
            Note note = new Note(titol, description, DateTime.Now);
            repository.Insert(note);
        }

        public IList<Note> All()
        {
            return repository.All();
        }
    }
}
