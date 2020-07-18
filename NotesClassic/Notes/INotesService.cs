
using System.Collections;
using System.Collections.Generic;

namespace Notes.Service
{
    interface INotesService
    {
        void Add(string titol, string description);

        IList<Note> All();

        void RemoveAll();
    }
}
