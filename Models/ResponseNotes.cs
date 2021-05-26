using Api_Nikita.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Nikita.Models
{
    public class ResponseNotes
    {
        public ResponseNotes(Notes responseNote)
        {
            id_note = responseNote.id_note;
            heading = responseNote.heading;
            textbody = responseNote.textbody;
            notedata = responseNote.notedata;
        }

        public int id_note { get; set; }
        public string heading { get; set; }
        public string textbody { get; set; }
        public string notedata { get; set; }
    }
}