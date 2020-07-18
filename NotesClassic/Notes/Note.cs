namespace Notes.Service
{
    public class Note
    {
        private readonly string titol;
        private readonly string description;

        public Note(string titol, string description)
        {
            this.titol = titol;
            this.description = description;
        }

        public string Titol => titol;
        public string Description => description;
    }
}