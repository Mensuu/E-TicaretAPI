using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("menekse/api/[controller]/[action]")]
    public class RefDataController : Controller
    {
        [HttpGet]
        public ActionResult<List<ParaBirimi>> ParaBirimi()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.ParaBirimis.ToList();
        }
        [HttpGet]
        public ActionResult<List<Cinsiyet>> Cinsiyet()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.Cinsiyets.ToList();
        }
        [HttpGet]
        public ActionResult<List<OdemeKanali>> OdemeKanali()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.OdemeKanalis.ToList();
        }

    }
}
