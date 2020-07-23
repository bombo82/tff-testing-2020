using Moq;
using Notes.Service;
using NUnit.Framework;
using System;

namespace Notes.UnitTest.Service
{
    public class NotesService_Test
    {
        Mock<INotesRepository> repository;
        Mock<IClock> clock;
        NotesService service;

        [SetUp]
        public void Setup()
        {
            repository = new Mock<INotesRepository>();
            clock = new Mock<IClock>();
            service = new NotesService(repository.Object, clock.Object);
        }

        [Test]
        public void ShouldAddANewNote()
        {
            service.Add("titolo", "descrizione");

            repository.Verify(repository => repository.Insert(It.IsAny<Note>()));
        }

        [Test]
        public void AddedNote_ShouldContainsTitleAndDescription()
        {
            service.Add("titolo", "descrizione");

            Note note = new Note("titolo", "descrizione", DateTime.Now);
            repository.Verify(repository => repository.Insert(note));
        }

        [Test]
        public void AddedNote_ShouldContainsCreationDate()
        {
            clock.SetReturnsDefault(new DateTime(2020, 12, 25));

            service.Add("titolo", "descrizione");

            DateTime expectedCreatedDate = new DateTime(2020, 12, 25);
            repository.Verify(repository =>
                repository.Insert(It.Is<Note>(note =>
                    note.CreatedDate == expectedCreatedDate
                ))
            );
        }
    }
}