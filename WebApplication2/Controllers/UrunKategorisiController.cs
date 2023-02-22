using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrunKategorisiController : Controller
    {
        [HttpGet]
        public ActionResult<List<VUrunKategorisi>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VUrunKategorisis.ToList();
        }

        [HttpPost]
        public IActionResult addNew(UrunKategorisiParam vm)
        {
            UrunKategorisi m = new UrunKategorisi();
            m.UrunKategorisi1 = vm.UrunKategorisi;
       
            ETicaretContext ctx = new ETicaretContext();
            ctx.UrunKategorisis.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.UrunKategorisiId);

        }
    }
}
