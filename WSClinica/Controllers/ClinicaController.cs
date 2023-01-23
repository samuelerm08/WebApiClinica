using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WSClinica.Data;
using WSClinica.Models;

namespace WSClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : ControllerBase
    {
        private readonly DbClinicaContext context;

        public ClinicaController(DbClinicaContext context)
        {
            this.context = context;
        }
        // Get
        [HttpGet]
        public ActionResult<IEnumerable<Clinica>> GetClinica()
        {
            return context.Clinicas.ToList();
        }
        //Get por Id
        [HttpGet("{id}") ]
        public ActionResult<Clinica> GetByID(int id)
        {
            Clinica clinica = (from c in context.Clinicas
                               where id == c.ClinicaId
                               select c).SingleOrDefault();
            return clinica;
        }
        [HttpPut]
        //Put
        public ActionResult Put(Clinica clinica)
        {

        }
        
        //Post
        //Delete
    }
}
