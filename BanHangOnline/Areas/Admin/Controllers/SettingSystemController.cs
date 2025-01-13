using BanHangOnline.Models;
using BanHangOnline.Models.EF;
using System.Linq;
using System.Web.Mvc;

namespace BanHangOnline.Areas.Admin.Controllers
{
    public class SettingSystemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/SettingSystem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_Setting()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddSetting(SettingSystemViewModel req)
        {
            SystemSetting set = null;
            var checkTitle = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingTitle"));
            if (checkTitle == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingTitle";
                set.StringValue = req.SettingTitle;
                db.SystemSettings.Add(set);
            }
            else
            {
                checkTitle.StringKey = req.SettingTitle;
                db.Entry(checkTitle).State = System.Data.Entity.EntityState.Modified;
            }
            //logo
            var checkLogo = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingLogo"));
            if (checkLogo == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingLogo";
                set.StringValue = req.SettingLogo;
                db.SystemSettings.Add(set);
            }
            else
            {
                checkLogo.StringValue = req.SettingLogo;
                db.Entry(checkLogo).State = System.Data.Entity.EntityState.Modified;
            }
            //Email
            var email = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingEmail"));
            if (email == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingEmail";
                set.StringValue = req.SettingEmail;
                db.SystemSettings.Add(set);
            }
            else
            {
                email.StringValue = req.SettingEmail;
                db.Entry(email).State = System.Data.Entity.EntityState.Modified;
            }
            //Hotline
            var Hotline = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingHotline"));
            if (Hotline == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingHotline";
                set.StringValue = req.SettingHotline;
                db.SystemSettings.Add(set);
            }
            else
            {
                Hotline.StringValue = req.SettingHotline;
                db.Entry(Hotline).State = System.Data.Entity.EntityState.Modified;
            }
            //TitleSeo
            var TitleSeo = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingTitleSeo"));
            if (TitleSeo == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingTitleSeo";
                set.StringValue = req.SettingTitleSeo;
                db.SystemSettings.Add(set);
            }
            else
            {
                TitleSeo.StringValue = req.SettingTitleSeo;
                db.Entry(TitleSeo).State = System.Data.Entity.EntityState.Modified;
            }
            //DessSeo
            var DessSeo = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingDesSeo"));
            if (DessSeo == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingDesSeo";
                set.StringValue = req.SettingDesSeo;
                db.SystemSettings.Add(set);
            }
            else
            {
                DessSeo.StringValue = req.SettingDesSeo;
                db.Entry(DessSeo).State = System.Data.Entity.EntityState.Modified;
            }
            //KeySeo
            var KeySeo = db.SystemSettings.FirstOrDefault(x => x.StringKey.Contains("SettingKeySeo"));
            if (KeySeo == null)
            {
                set = new SystemSetting();
                set.StringKey = "SettingKeySeo";
                set.StringValue = req.SettingKeySeo;
                db.SystemSettings.Add(set);
            }
            else
            {
                KeySeo.StringValue = req.SettingKeySeo;
                db.Entry(KeySeo).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            return View("Partial_Setting");
        }
    }
}