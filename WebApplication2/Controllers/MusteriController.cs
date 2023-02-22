using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusteriController : Controller
    {
        [HttpGet]
        public ActionResult<List<VMusteri>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VMusteris.ToList();
        }
        
        [HttpPost]
        public IActionResult addNew(MusteriParam vm)
        {
            Musteri m = new Musteri();
            m.MusteriAdi = vm.MusteriAdi;
            m.MusteriSoyadi= vm.MusteriSoyadi;
            m.DogumTarihi = vm.DogumTarihi;
            m.CinsiyetId= vm.Cinsiyet;
            m.Adres = vm.Adres;
            m.SehirId = vm.Sehir;

            ETicaretContext ctx = new ETicaretContext();
            ctx.Musteris.Add(m);
            ctx.SaveChanges();
            return Ok("Kayıt başarılıdır kayıt numaranız :" + m.MusteriId);

        }

        //[HttpGet]
        //public ActionResult<IEnumerable> Index()
        //{
        //    ETicaretContext ctx = new ETicaretContext();
        //    return ctx.Musteris.Select(m => new
        //    {
        //        Ad = m.MusteriAdi,
        //        Soyad = m.MusteriSoyadi
        //        Mensu = System.DateTime.Now,

        //    }).ToList();
        //}

        //public class Kisi
        //{
        //    pubic string Ad { get; set; }
        //    public string Soyad { get; set; }
        //}
    }  
}
