using subota1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace subota1.Controllers
{
    public class KlubController : ApiController
    {
        // GET: api/Default
        [HttpGet]
        [Route("api/getklub")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value23", "value2" };
        }

        // GET: api/Default/5
        [HttpGet]
        [Route("api/getklubs")]
        public string Get(int id)
        {
            Klub foundKlub = klubs.Find(klub => klub.KlubId == id);
            return $"The Klub with the id#{id} is {foundKlub.KlubName} iz {foundKlub.KlubCityName}";
            //return "value";
        }
        public class Klubs
        {
            List<Klub> klubs;
        }
        static List<Klub> klubs = new List<Klub>();
        [HttpPost]
        [Route("webApi/Klub")]

        // POST: api/Default    
        public string InsertNewPlayer(Klub newKlub)
        {
            klubs.Add(newKlub);
            Klub klub = new Klub();
            klub.KlubName = klubs.Last().KlubName;
            klub.KlubCityName = klubs.Last().KlubCityName;
            klub.KlubCountryName = klubs.Last().KlubCountryName;
           /klub.KlubId =klubs.Last().KlubId;
                return $"A new klub {newKlub.KlubId} {klub.KlubName} {klub.KlubCityName}  {klub.KlubCountryName}";
        }
               
        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
