using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesTakingApp
{
    internal class Note
    {

        public string title { get; set; }
        public string notes { get; set; }

        public Note(string title, string note)
        {
            this.title = title;
            this.notes = note;
        }
    }
}
