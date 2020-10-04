using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Geribello.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController : Controller
    {
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

           string result = id + " Excluido com sucesso!";

           return Ok(result);
        }


        [HttpPost]
        public IActionResult Post([FromBody]AlunoModel aluno)
        {
           string result = aluno.Id + " Cadastrado com sucesso";

           return Ok(result);
        }

    }
}
