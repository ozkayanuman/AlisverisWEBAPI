using DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCAlisVeris.Controllers
{
    public class AlisVerisListesiController : Controller
    {
        // GET: AlisVerisListesi
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> UrunleriGetir()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:44300/api/Servis");
                var model = JsonConvert.DeserializeObject <List<Urun>>(response.Content.ReadAsStringAsync().Result);

                return View(model);
            }
        }
    }
}