using Api_Nikita.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Nikita.Models
{
    public class ResponseTrainingParts
    {
        public ResponseTrainingParts(TrainingParts responseTrainingParts)
        {
            id_trainigpart = responseTrainingParts.id_trainigpart;
            auditorium = responseTrainingParts.auditorium;
            academic_subject = responseTrainingParts.academic_subject;
            acc_FK = (int)responseTrainingParts.acc_FK;
        }

        public int id_trainigpart { get; set; }
        public string auditorium { get; set; }
        public string academic_subject { get; set; }
        public int acc_FK { get; set; }

    }
}