using Notes.Service;
using NUnit.Framework;
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
        public void ShouldAddANewNote()
        {
            TestNotesRepository repository = new TestNotesRepository();
            NotesService service = new NotesService(repository);
            service.Add("titolo", "descrizione");

            Assert.That(repository.notes, Has.Count.EqualTo(1));
        }

        [Test]
        public void AddedNote_ShouldContainsTitleAndDescription()
        {
            TestNotesRepository repository = new TestNotesRepository();
            NotesService service = new NotesService(repository);
            service.Add("titolo", "descrizione");

            Note note = repository.notes.First();
            Assert.That(note.title, Is.EqualTo("titolo"));
            Assert.That(note.description, Is.EqualTo("descrizione"));
        }
    }
}