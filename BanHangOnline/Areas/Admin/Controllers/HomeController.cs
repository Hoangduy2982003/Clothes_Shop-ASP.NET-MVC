using System.Web.Mvc;

namespace BanHangOnline.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin,Employee")]
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}