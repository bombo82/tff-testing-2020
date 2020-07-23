using Moq;
using Notes.Service;
using NUnit.Framework;

namespace Notes.UnitTest.Service
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAddANewNote()
        {
            Mock<INotesRepository> respository = new Mock<INotesRepository>();
            NotesService service = new NotesService(respository.Object);

            service.Add("titolo", "descrizione");

            respository.Verify(repo => repo.Insert(It.IsAny<Note>()));
        }
    }
}