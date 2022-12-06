using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace AreasWithAuth.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfileController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public ProfileController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImageSave(string imgBase64)
        {
            Console.WriteLine(imgBase64);
            Image img;
            //img = Image.FromStream();
            if (!string.IsNullOrEmpty(imgBase64))
            {
                byte[] imgConvert = Convert.FromBase64String(imgBase64.Substring(22));
                var ms = new MemoryStream(imgConvert, 0, imgConvert.Length);
                ms.Write(imgConvert, 0, imgConvert.Length);
                 img = Image.FromStream(ms, true);
                string filename = Guid.NewGuid() + ".png";
                img.Save(_env.ContentRootPath + "/dosyalar/profilephoto/" + filename);
                
            }

            return Json(imgBase64);
        }
    }
}
