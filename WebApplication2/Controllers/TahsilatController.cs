using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TahsilatController : Controller
    {
        [HttpGet]
        public ActionResult<List<VTahsilat>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VTahsilats.ToList();
        }

        [HttpPost]
        public IActionResult addNew(TahsilatParam vm)
        {
            Tahsilat m = new Tahsilat();
            m.MusteriId = vm.Musteri;
            m.ParaBirimiId = vm.ParaBirimi;
            m.ToplamTutar = vm.ToplamTutar;
            m.UrunId = vm.Urun;
            m.TahsilatTipiId = vm.TahsilatTipi;

            ETicaretContext ctx = new ETicaretContext();
            ctx.Tahsilats.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.TahsilatId);
        }
    }
}
