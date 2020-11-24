using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practica007.Models;

namespace Practica007.Controllers
{
    public class GestorController : ApiController
    {
        //  GET: api/Gestor
        public IEnumerable<Legajo> Get()
        {
            ClassGestor classGestor = new ClassGestor();
            List<Legajo> lista = classGestor.ObtenerLegajos();
            return lista;
        }

        // GET: api/Gestor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Gestor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Gestor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Gestor/5
        public void Delete(int id)
        {
        }
    }
}
