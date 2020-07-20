using System;

namespace Notes.Service
{
    public class Note
    {
        public readonly string title;
        public readonly string description;
        public readonly DateTime creationDate;

        public Note(string title, string description, DateTime creationDate)
        {
            this.title = title;
            this.description = description;
            this.creationDate = creationDate;
        }
    }
}
