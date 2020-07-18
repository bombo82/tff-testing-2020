using Notes.Service;
using Notes.UnitTest.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Notes.UnitTest.Service
{
    public class NotesService_Test
    {

        private TestNotesRepository repository;
        private IClock testClock;
        private NotesService notesService;

        [SetUp]
        public void Setup()
        {
            repository = new TestNotesRepository();
            testClock = new TestClock();
            notesService = new NotesService(repository, testClock);
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
            expectedNotes.Add(new Note("titolo 1", "Descrizione 1", DateTime.Now));
            expectedNotes.Add(new Note("titolo 2", "Descrizione 2", DateTime.Now));
            expectedNotes.Add(new Note("titolo 3", "Descrizione 3", DateTime.Now));
            repository.notes = expectedNotes;

            IList<Note> notes = notesService.All();

            Assert.That(notes, Has.Count.EqualTo(3));
            Assert.That(notes[0], Is.EqualTo(expectedNotes[0]));
            Assert.That(notes[1], Is.EqualTo(expectedNotes[1]));
            Assert.That(notes[2], Is.EqualTo(expectedNotes[2]));
        }

        [Test]
        public void ANote_ShouldHaveCreationDate()
        {
            notesService.Add("titolo", "descrizione");

            IList<Note> notes = repository.notes;

            Note note = notes.First();
            DateTime creationDate = testClock.Now();
            Assert.That(note.CreationDate, Is.EqualTo(creationDate));
        }

        [Test]
        public void ShouldRemoveAllNotes()
        {
            notesService.RemoveAll();

            Assert.That(repository.notes, Is.Empty);
        }
    }
}