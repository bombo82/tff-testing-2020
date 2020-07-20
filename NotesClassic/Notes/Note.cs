namespace Notes.Service
{
    public class Note
    {
        public readonly string title;
        public readonly string description;

        public Note(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
