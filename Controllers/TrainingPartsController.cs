using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Api_Nikita.Entities;

namespace Api_Nikita.Controllers
{
    public class TrainingPartsController : ApiController
    {
        private OwndbEntities db = new OwndbEntities();

        // GET: api/TrainingParts
        public IQueryable<object> GetTrainingParts()
        {
            return from a in db.TrainingParts
                   join p in db.Accs on a.acc_FK equals p.id_acc into Accs
                   select new
                   {
                       id_trainigpart = a.id_trainigpart,
                       auditorium = a.auditorium,
                       academic_subject = a.academic_subject,
                       surname = Accs.Select(ap => ap.mylastname).FirstOrDefault(),
                       name = Accs.Select(ap => ap.myname).FirstOrDefault(),
                       patronymic = Accs.Select(ap => ap.mypatronymic).FirstOrDefault(),
                   };
        }

        // GET: api/TrainingParts/5
        [ResponseType(typeof(TrainingParts))]
        public IHttpActionResult GetTrainingPart(int id)
        {
            TrainingParts trainingPart = db.TrainingParts.Find(id);
            if (trainingPart == null)
            {
                return NotFound();
            }

            return Ok(trainingPart);
        }

        // PUT: api/TrainingParts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTrainingPart(int id, TrainingParts trainingPart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trainingPart.id_trainigpart)
            {
                return BadRequest();
            }

            db.Entry(trainingPart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingPartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TrainingParts
        [ResponseType(typeof(TrainingParts))]
        public IHttpActionResult PostTrainingPart(TrainingParts trainingPart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TrainingParts.Add(trainingPart);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = trainingPart.id_trainigpart }, trainingPart);
        }

        // DELETE: api/TrainingParts/5
        [ResponseType(typeof(TrainingParts))]
        public IHttpActionResult DeleteTrainingPart(int id)
        {
            TrainingParts trainingPart = db.TrainingParts.Find(id);
            if (trainingPart == null)
            {
                return NotFound();
            }

            db.TrainingParts.Remove(trainingPart);
            db.SaveChanges();

            return Ok(trainingPart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrainingPartExists(int id)
        {
            return db.TrainingParts.Count(e => e.id_trainigpart == id) > 0;
        }
    }
}