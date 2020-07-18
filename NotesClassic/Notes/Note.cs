using System;

namespace Notes.Service
{
    public class Note
    {
        private readonly string titol;
        private readonly string description;
        private readonly DateTime creationDate;

        public Note(string titol, string description, DateTime creationDate)
        {
            this.titol = titol;
            this.description = description;
            this.creationDate = creationDate;
        }

        public string Titol => titol;
        public string Description => description;
        public DateTime CreationDate => creationDate;
    }
}