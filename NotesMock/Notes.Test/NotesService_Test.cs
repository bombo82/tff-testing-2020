using Moq;
using Notes.Service;
using NUnit.Framework;
using System;

namespace Notes.UnitTest.Service
{
    public class Tests
    {
        private Mock<INotesRepository> respository;
        private Mock<IClock> clock;
        private NotesService service;

        [SetUp]
        public void Setup()
        {
            respository = new Mock<INotesRepository>();
            clock = new Mock<IClock>();
            service = new NotesService(respository.Object, clock.Object);
        }

        [Test]
        public void ShouldAddANewNote()
        {
            service.Add("titolo", "descrizione");

            respository.Verify(repo => repo.Insert(It.IsAny<Note>()));
        }

        [Test]
        public void AddedNote_ShouldContainsTitleAndDescription()
        {
            Note expectedNote = new Note("titolo", "descrizione", DateTime.Now);

            service.Add("titolo", "descrizione");

            respository.Verify(repo => repo.Insert(expectedNote));
        }

        [Test]
        public void AddedNote_ShouldContainsCreationDate()
        {
            clock.SetReturnsDefault(new DateTime(2000, 12, 25));

            DateTime expectedCreationDate = new DateTime(2000, 12, 25);
            service.Add("titolo", "descrizione");

            respository.Verify(repo =>
                repo.Insert(It.Is<Note>(note =>
                    note.creationDate == expectedCreationDate
                ))
            );
        }
    }
}