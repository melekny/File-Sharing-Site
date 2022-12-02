using FileSharingSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FileSharingSite.Controllers
{
    public class MemberController : Controller
    {
        [HttpGet]
        public IActionResult MemberRegister()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MemberRegister(MemberViewModel member)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index");
            else
                return BadRequest("Bir sorun oluştu! Lütfen tekrar deneyiniz.");

        }

    }
}
