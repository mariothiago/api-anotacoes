using anotacoesapi.Infrastructure.Model;
using anotacoesapi.Infrastructure.Service;
using anotacoesapi.Infrastructure.Service.Interface;
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
        private IAnotacoesService _anotacaoService { get; set; }

        public AnotacoesController(IAnotacoesService service)
        {
            _anotacaoService = service;
        }

        //GET
        //[HttpGet("listar-por-id")]
        //public async Task<IActionResult> GetById([FromQuery]long id)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);
        //    try
        //    {
        //        var result = await _anotacaoService.GetById(id);

        //        if (result != null)
        //            return Ok(result);

        //        else
        //            return BadRequest();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}

        // GET
        [HttpGet("listar-todas")]
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

                if (result > 0)
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

                if (result > 0)
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

                if (result > 0)
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
