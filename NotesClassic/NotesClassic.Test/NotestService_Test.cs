using Notes.Repository;
using Notes.Service;
using Notes.UnitTest.Repository;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Notes.UnitTest.Service
{
    public class NotesService_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAddNewANote()
        {
            NotesRepository repository = new NotesRepository();
            NotesService notesService = new NotesService(repository);
            notesService.Add("titolo", "descrizione");

            IList<Note> notes = repository.notes;
            Assert.That(notes, Has.Count.EqualTo(1));
            
            Note note = notes.First();
            Assert.That(note.Titol, Is.EqualTo("titolo"));
            Assert.That(note.Description, Is.EqualTo("descrizione"));
        }
    }
}