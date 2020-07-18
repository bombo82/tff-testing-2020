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

        [Test]
        public void ShouldReturAListOfAddedNotes()
        {
            List<Note> expectedNotes = new List<Note>();
            expectedNotes.Add(new Note("titolo 1", "Descrizione 1"));
            expectedNotes.Add(new Note("titolo 2", "Descrizione 2"));
            expectedNotes.Add(new Note("titolo 3", "Descrizione 3"));
            repository.notes = expectedNotes;

            IList<Note> notes = notesService.All();

            Assert.That(notes, Has.Count.EqualTo(3));
            Assert.That(notes[0], Is.EqualTo(expectedNotes[0]));
            Assert.That(notes[1], Is.EqualTo(expectedNotes[1]));
            Assert.That(notes[2], Is.EqualTo(expectedNotes[2]));
        }
    }
}