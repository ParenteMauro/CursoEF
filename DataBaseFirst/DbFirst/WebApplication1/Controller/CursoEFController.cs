using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; 

namespace WebApplication1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoEFController : ControllerBase
    {
        private readonly CursoEfContext _cursoEfContext;



        public CursoEFController(CursoEfContext cursoEfContext)
        {
             _cursoEfContext = cursoEfContext;
        }


        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
           var response = await _cursoEfContext.Get(id);
           return Ok(response);
        }
    }
}
