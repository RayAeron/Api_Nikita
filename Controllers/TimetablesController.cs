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
using Api_Nikita.Models;

namespace Api_Nikita.Controllers
{
    public class TimetablesController : ApiController
    {
        private OwndbEntities db = new OwndbEntities();

        // GET: api/Timetables
        [ResponseType(typeof(List<ResponseTimetables>))]
        public IHttpActionResult GetTimetables()
        {
            return Ok(db.Timetables.ToList().ConvertAll(p => new ResponseTimetables(p)));
        }

        // GET: api/Timetables/5
        [ResponseType(typeof(Timetables))]
        public IHttpActionResult GetTimetable(int id)
        {
            Timetables timetable = db.Timetables.Find(id);
            if (timetable == null)
            {
                return NotFound();
            }

            return Ok(timetable);
        }

        // PUT: api/Timetables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTimetable(int id, Timetables timetable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != timetable.id_timetable)
            {
                return BadRequest();
            }

            db.Entry(timetable).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimetableExists(id))
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

        // POST: api/Timetables
        [ResponseType(typeof(Timetables))]
        public IHttpActionResult PostTimetable(Timetables timetable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Timetables.Add(timetable);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = timetable.id_timetable }, timetable);
        }

        // DELETE: api/Timetables/5
        [ResponseType(typeof(Timetables))]
        public IHttpActionResult DeleteTimetable(int id)
        {
            Timetables timetable = db.Timetables.Find(id);
            if (timetable == null)
            {
                return NotFound();
            }

            db.Timetables.Remove(timetable);
            db.SaveChanges();

            return Ok(timetable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TimetableExists(int id)
        {
            return db.Timetables.Count(e => e.id_timetable == id) > 0;
        }
    }
}