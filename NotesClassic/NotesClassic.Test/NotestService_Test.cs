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

        NotesRepository repository;
        NotesService notesService;

        [SetUp]
        public void Setup()
        {
            repository = new NotesRepository();
            notesService = new NotesService(repository);
        }

        [Test]
        public void ShouldAddNewANote()
        {
            notesService.Add("titolo", "descrizione");

            IList<Note> notes = repository.notes;
            Assert.That(notes, Has.Count.EqualTo(1));
            
            Note note = notes.First();
            Assert.That(note.Titol, Is.EqualTo("titolo"));
            Assert.That(note.Description, Is.EqualTo("descrizione"));
        }

        [Test]
        public void ShouldReturnEmptyList_BeforeAddANewNote()
        {
            IList<Note> notes = notesService.All();

            Assert.That(notes, Is.Empty);
        }
    }
}