using Notes.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    interface INotesService
    {
        void Add(string titol, string description);

        IList<Note> All();

        void Clear();
    }
}
