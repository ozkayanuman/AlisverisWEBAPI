using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servis.Controllers
{
    public class ServisController : ApiController
    {
        // GET: api/Servis
        public List<Urun> Get()
        {
            using (AlisVerisContext context = new AlisVerisContext())
            {
                return context.Urunler.ToList();
            }
        }

        // GET: api/Servis/5
        public Urun Get(int id)
        {
            using (AlisVerisContext context = new AlisVerisContext())
            {
                return context.Urunler.Single(u=> u.id==id);
            }
        }

        // POST: api/Servis
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Servis/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Servis/5
        public void Delete(int id)
        {
        }
    }
}
