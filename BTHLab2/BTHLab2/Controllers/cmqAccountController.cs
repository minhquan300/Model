using BTHLab2.Models;
using Microsoft.AspNetCore.Http;    
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace BTHLab2.Controllers
{
    public class CmqAccountController : Controller
    {
        private static List<CmqAccount> acounts = new List<CmqAccount>();
        // GET: CmqAccountController
        public ActionResult Index()
        {
            return View(acounts);
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex is_phone = new Regex(
                @"^(\([0-9]{3}\))?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"
            );

            if (string.IsNullOrEmpty(phone) || !is_phone.IsMatch(phone))
            {
                return Json(
                    $"Số điện thoại {phone} không đúng định dạng, VD: 0986421127 hoặc 098.421.1127"
                );
            }

            return Json(true);
        }
        // GET: CmqAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CmqAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CmqAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CmqAccount cmqAccounts)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(cmqAccounts);
                }
                acounts.Add(cmqAccounts);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CmqAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CmqAccountController/Edit/5
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

        // GET: CmqAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CmqAccountController/Delete/5
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
