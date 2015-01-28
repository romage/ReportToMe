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
using ReportToMe.Web.Models;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ReportToMe.Web.Controllers
{
    public class MeetingController : Controller
    {
        private IMeetingService _svc;

        public MeetingController(IMeetingService meetingService)
        {
            this._svc = meetingService;
        }

        // GET: Meetings
        public async Task<ActionResult> Index()
        {
            return View(await _svc.ListMeetingsAsync());
        }

        private JsonSerializerSettings jsonSetting() { 
            return new JsonSerializerSettings { 
                        Formatting= Newtonsoft.Json.Formatting.Indented,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore, 
                        ContractResolver = new CamelCasePropertyNamesContractResolver() 
                        };
        }

        public ActionResult IndexNg()
        {
            var model =  _svc.List().ToList();
           
            var modelJson = JsonConvert.SerializeObject(model,jsonSetting());
            ViewBag.PreloadedData = modelJson;
            return PartialView();
        }

        // GET: Meetings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            var model = new MeetingDetailsModel();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = null;
            var getMeetingAsync = Task.Factory.StartNew(() =>
            {
                meeting = _svc.Find(et => et.Id == id.Value);
            });
            await getMeetingAsync;
            
            if (meeting == null)
            {
                return HttpNotFound();
            }
            model.Meeting = meeting;
            model.DepartmentsForMeetings = _svc.GetDepartmentForMeetingsList(id.Value).ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> DetailsJson(int? id)
        {
            var model = new MeetingDetailsModel();

            Meeting meeting = null;
            var getMeetingAsync = Task.Factory.StartNew(() =>
            {
                meeting = _svc.Find(et => et.Id == id.Value);
            });
            await getMeetingAsync;

            if (meeting == null)
            {
                return HttpNotFound();
            }
            model.Meeting = meeting;
            model.DepartmentsForMeetings = _svc.GetDepartmentForMeetingsList(id.Value).ToList();
            return Json(model);
        } 

        // GET: Meetings/Create
        public ActionResult Create()
        {
            var meeting = new Meeting();
            return View(meeting);
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,MeetingDate,Description")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                var newAddTask = Task.Factory.StartNew(() =>
                {
                    _svc.Add(meeting);
                });
                //await db.SaveChangesAsync();
                await newAddTask;
                return RedirectToAction("Index");
            }

            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = _svc.Find(et=>et.Id==id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MeetingDate,Description")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                //_svc.Update(meeting);
                return RedirectToAction("Index");
            }
            return View(meeting);
        }

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
