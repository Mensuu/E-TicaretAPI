using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SehirController : Controller
    {
        [HttpGet]
        public ActionResult<List<VSehir>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VSehirs.ToList();
        }

        [HttpPost]
        public IActionResult addNew(SehirParam vm)
        {
            Sehir m = new Sehir();
            m.Sehir1 = vm.Sehir;

            ETicaretContext ctx = new ETicaretContext();
            ctx.Sehirs.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.SehirId);

        }
    }
}
