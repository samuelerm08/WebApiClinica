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
    public class HabitacionController : ControllerBase
    {
        private DbClinicaContext context;

        public HabitacionController(DbClinicaContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Habitacion>> Get()
        {
            return context.Habitaciones.ToList();
        }
    }
}
