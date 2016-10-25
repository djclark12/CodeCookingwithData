using CodeCookingwithData.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CodeCookingwithData.Quarterbacks
{
    public class PassingStatsModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PassingStatsModels
        public async Task<ActionResult> Index()
        {
            return View(await db.PassingStats.ToListAsync());
        }

        // GET: PassingStatsModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PassingStatsModel passingStatsModel = await db.PassingStats.FindAsync(id);
            if (passingStatsModel == null)
            {
                return HttpNotFound();
            }
            return View(passingStatsModel);
        }

        // GET: PassingStatsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PassingStatsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PlayerId,Name,Age,DateTime,Team,IsAway,OppTeam,Result,GameNum,Week,DayOfWeek,PassCmp,PassAtt,CmpPercent,PassYds,PassTds,Interceptions,Rating,PassYdsperAtt,PassAdjYdsperAtt")] PassingStatsModel passingStatsModel)
        {
            if (ModelState.IsValid)
            {
                db.PassingStats.Add(passingStatsModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(passingStatsModel);
        }

        // GET: PassingStatsModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PassingStatsModel passingStatsModel = await db.PassingStats.FindAsync(id);
            if (passingStatsModel == null)
            {
                return HttpNotFound();
            }
            return View(passingStatsModel);
        }

        // POST: PassingStatsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PlayerId,Name,Age,DateTime,Team,IsAway,OppTeam,Result,GameNum,Week,DayOfWeek,PassCmp,PassAtt,CmpPercent,PassYds,PassTds,Interceptions,Rating,PassYdsperAtt,PassAdjYdsperAtt")] PassingStatsModel passingStatsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passingStatsModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(passingStatsModel);
        }

        // GET: PassingStatsModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PassingStatsModel passingStatsModel = await db.PassingStats.FindAsync(id);
            if (passingStatsModel == null)
            {
                return HttpNotFound();
            }
            return View(passingStatsModel);
        }

        // POST: PassingStatsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PassingStatsModel passingStatsModel = await db.PassingStats.FindAsync(id);
            db.PassingStats.Remove(passingStatsModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
