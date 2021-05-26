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
    public class NotesController : ApiController
    {
        private OwndbEntities db = new OwndbEntities();

        // GET: api/Notes
        [ResponseType(typeof(List<ResponseNotes>))]
        public IHttpActionResult Getnote()
        {
            return Ok(db.Notes.ToList().ConvertAll(p => new ResponseNotes(p)));
        }

        // GET: api/Notes/5
        [ResponseType(typeof(Notes))]
        public IHttpActionResult GetNote(int id)
        {
            Notes note = db.Notes.Find(id);
            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        // PUT: api/Notes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNote(int id, Notes note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != note.id_note)
            {
                return BadRequest();
            }

            db.Entry(note).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteExists(id))
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

        // POST: api/Notes
        [ResponseType(typeof(Notes))]
        public IHttpActionResult PostNote(Notes note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notes.Add(note);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = note.id_note }, note);
        }

        // DELETE: api/Notes/5
        [ResponseType(typeof(Notes))]
        public IHttpActionResult DeleteNote(int id)
        {
            Notes note = db.Notes.Find(id);
            if (note == null)
            {
                return NotFound();
            }

            db.Notes.Remove(note);
            db.SaveChanges();

            return Ok(note);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NoteExists(int id)
        {
            return db.Notes.Count(e => e.id_note == id) > 0;
        }
    }
}