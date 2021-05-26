using Api_Nikita.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Nikita.Models
{
    public class ResponseTimetables
    {
        public ResponseTimetables(Timetables responseTimetable)
        {
            id_timetable = responseTimetable.id_timetable;
            timetable_img = responseTimetable.timetable_img;
        }

        public int id_timetable { get; set; }
        public byte[] timetable_img { get; set; }

    }
}
