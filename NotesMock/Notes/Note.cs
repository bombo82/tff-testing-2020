using System;

namespace Notes
{
    public class Note
    {
        public string Title { get; }
        public string Description { get; }

        public Note(string title, string description)
        {
            Title = title;
            Description = description;
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
