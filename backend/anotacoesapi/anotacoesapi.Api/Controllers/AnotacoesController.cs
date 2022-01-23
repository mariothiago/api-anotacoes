using anotacoesapi.Infrastructure.Model;
using anotacoesapi.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace anotacoesapi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotacoesController : Controller
    {
        private AnotacoesService _anotacaoService { get; set; }

        public AnotacoesController(AnotacoesService service)
        {
            _anotacaoService = service;
        }

        // GET
        [HttpGet("listar")]
        public async Task <IActionResult> GetAllAnotations()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _anotacaoService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // POST
        [HttpPost("criar")]
        public async Task<IActionResult> CreateAnotation([FromBody] AnotacoesModel notas)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _anotacaoService.Create(notas);

                if (result != null)
                    return Ok(result);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }

        // PUT
        [HttpPut("alterar")]
        public async Task<IActionResult> UpdateAnotation([FromBody] AnotacoesModel anotacoes)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _anotacaoService.Update(anotacoes);

                if (result != null)
                    return Ok(result);

                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }

        // DELETE
        [HttpDelete("apagar")]
        public async Task<IActionResult> DeleteAnotation(long id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _anotacaoService.Delete(id);

                if (result != null)
                    return Ok(result);

                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
