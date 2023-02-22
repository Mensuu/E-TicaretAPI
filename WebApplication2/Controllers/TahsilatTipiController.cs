using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TahsilatTipiController : Controller
    {
        [HttpGet]
        public ActionResult<List<VTahsilatTipi>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VTahsilatTipis.ToList();
        }

        [HttpPost]
        public IActionResult addNew(TahsilatTipiParam vm)
        {
            TahsilatTipi m = new TahsilatTipi();
            m.TahilatTipi = vm.TahsilatTipi;

            ETicaretContext ctx = new ETicaretContext();
            ctx.TahsilatTipis.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.TahsilatTipiId);

        }
    }
}
