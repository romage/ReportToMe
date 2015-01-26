using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReportToMe.Data;
using ReportToMe.Models;
using ReportToMe.Web.Interfaces;

namespace ReportToMe.Web.Controllers
{
    public class MeetingsController : Controller
    {
        private IMeetingService _svc;

        public MeetingsController(IMeetingService meetingService)
        {
            this._svc = meetingService;
        }

        // GET: Meetings
        public async Task<ActionResult> Index()
        {
            return View(await _svc.ListMeetingsAsync());
        }

        //// GET: Meetings/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Meeting meeting = await db.Meetings.FindAsync(id);
        //    if (meeting == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(meeting);
        //}

        //// GET: Meetings/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Meetings/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "Id,MeetingDate,Description")] Meeting meeting)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Meetings.Add(meeting);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    return View(meeting);
        //}

        //// GET: Meetings/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Meeting meeting = await db.Meetings.FindAsync(id);
        //    if (meeting == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(meeting);
        //}

        //// POST: Meetings/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,MeetingDate,Description")] Meeting meeting)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(meeting).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(meeting);
        //}

        //// GET: Meetings/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Meeting meeting = await db.Meetings.FindAsync(id);
        //    if (meeting == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(meeting);
        //}

        //// POST: Meetings/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Meeting meeting = await db.Meetings.FindAsync(id);
        //    db.Meetings.Remove(meeting);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //_svc.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
