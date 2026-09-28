using Annotation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Annotation.Controllers
{
    
    public class CmqMembersController : Controller
    {
        private static List<CmqMember> cmqMembers = new List<CmqMember>();
        // GET: CmqMembersController
        public ActionResult Index()
        {

            return View(cmqMembers);
        }

        // GET: CmqMembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CmqMembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CmqMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CmqMember cmqMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(cmqMember);
                }
                cmqMembers.Add(cmqMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CmqMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CmqMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CmqMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CmqMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
