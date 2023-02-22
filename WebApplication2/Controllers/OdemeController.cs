using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OdemeController : Controller
    {
        [HttpGet]
        public ActionResult<List<VOdeme>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VOdemes.ToList();
        }

        [HttpPost]
        public IActionResult addNew(OdemeParam vm)
        {
            Odeme m = new Odeme();
            m.MusteriId = vm.Musteri;
            m.OdemeTarihi = vm.OdemeTarihi;
            m.ParaBirimiId = vm.ParaBirimi;
            m.ToplamTutar = vm.ToplamTutar;
            m.OdemeKanaliId = vm.OdemeKanali;
            m.Aciklama = vm.Aciklama;


            ETicaretContext ctx = new ETicaretContext();
            ctx.Odemes.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.OdemeId);

        }
    }
}
