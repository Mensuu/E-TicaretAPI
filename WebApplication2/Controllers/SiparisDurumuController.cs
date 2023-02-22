using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiparisDurumuController : Controller
    {
        [HttpGet]
        public ActionResult<List<VSiparisDurumu>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VSiparisDurumus.ToList();
        }

        [HttpPost]
        public IActionResult addNew(SiparisDurumuParam vm)
        {
            SiparisDurumu m = new SiparisDurumu();
            m.SiparisDurumu1 = vm.SiparisDurumu;

            ETicaretContext ctx = new ETicaretContext();
            ctx.SiparisDurumus.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.SiparisDurumuId);

        }
    }
}
