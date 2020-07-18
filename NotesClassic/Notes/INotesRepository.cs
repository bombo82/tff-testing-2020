using Notes.Service;
using System.Collections.Generic;

namespace Notes.Repository
{
    public interface INotesRepository
    {
        void Insert(Note note);
    }
}
