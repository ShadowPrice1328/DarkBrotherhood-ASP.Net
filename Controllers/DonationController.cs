using HelloASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloASP.Controllers
{
	public class DonationController : Controller
	{
        [HttpPost]
        public IActionResult ConfirmDonation(IFormCollection form)
		{
            string gift = form["gift"];
            DonationModel model = new();
            model.SaveDonation(gift);
            return View("Donate");
        }
        public IActionResult Donate()
        {
            return View();
        }
    }
}
