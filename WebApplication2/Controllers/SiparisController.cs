using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiparisController : Controller
    {
        [HttpGet]
        public ActionResult<List<VSiparis>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VSipariss.ToList();
        }

        [HttpPost]
        public IActionResult addNew(SiparisParam vm)
        {
            Sipari m = new Sipari();
            m.MusteriId = vm.SiparisVeren;
            m.SiparisTarihi = vm.SiparisTarihi;
            m.ParaBirimiId = vm.ParaBirimi;
            m.ToplamTutar = vm.ToplamTutar;
            m.SiparisDurumuId = vm.SiparisDurumu;
            m.SiparisDetayları = vm.SiparisDetaylari;

            ETicaretContext ctx = new ETicaretContext();
            ctx.Siparis.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.SiparisId);

        }
    }
}

