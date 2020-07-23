using Moq;
using Notes.Service;
using NUnit.Framework;
using System;

namespace Notes.UnitTest.Service
{
    public class NotesService_Test
    {
        Mock<INotesRepository> repository;
        NotesService service;

        [SetUp]
        public void Setup()
        {
            repository = new Mock<INotesRepository>();
            service = new NotesService(repository.Object);
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

            Note note = new Note("titolo", "descrizione");
            repository.Verify(repository => repository.Insert(note));
        }

    }
}