using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Desafio.Model;
using Desafio.Data;
using System.Threading.Tasks;


namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DespesaController: ControllerBase
    {
        [HttpGet]
        [Route("todas")]
        public async Task<IActionResult> GetAll(
            [FromServices] AppDbContext context
        )
        {
            var despesas = await context.Despesas.AsnoTracking().TolistAsync();
            return despesas; 
        }
    }
}
