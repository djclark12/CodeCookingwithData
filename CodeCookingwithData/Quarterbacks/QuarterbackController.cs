using System.Web.Mvc;

namespace CodeCookingwithData.Quarterbacks
{
    public class QuarterbackController : Controller
    {
        // GET: Quarterback
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: Quarterback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quarterback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quarterback/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quarterback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quarterback/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quarterback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quarterback/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
