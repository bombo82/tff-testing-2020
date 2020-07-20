using System.Collections.Generic;

namespace Notes.Service
{
    public interface INotesRepository
    {
        void Insert(Note note);
        IList<Note> FindAll();
    }
}
