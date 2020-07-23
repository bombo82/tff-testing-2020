using System;

namespace Notes
{
    public class Note
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime CreatedDate { get; }

        public Note(string title, string description, DateTime createdDate)
        {
            Title = title;
            Description = description;
            CreatedDate = createdDate;
        }

        public override bool Equals(object obj)
        {
            return obj is Note note &&
                   Title == note.Title &&
                   Description == note.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Description);
        }
    }
}
