using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrunController : Controller
    {
        [HttpGet]
        public ActionResult<List<VUrun>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VUruns.ToList();
        }

        [HttpPost]
        public IActionResult addNew(UrunParam vm)
        {
            Urun m = new Urun();
            m.UrunAdi = vm.UrunAdi;
            m.UrunKodu = vm.UrunKodu;
            m.ParaBirimiId = vm.ParaBirimi;
            m.Fiyati = vm.Fiyati;
            m.Stok = vm.Stok;
            m.Aciklama = vm.Aciklama;
            m.UrunKategorisiId = vm.UrunKategorisi;

            ETicaretContext ctx = new ETicaretContext();
            ctx.Uruns.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.UrunId);

        }
    }
}
