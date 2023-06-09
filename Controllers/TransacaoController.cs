using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dto;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoService _service;
        private TransacaoDto transacao;

        public TransacaoController(ITransacaoService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(TransacaoDto transacao)
        {
            _service.Create(transacao);
            return Created("", transacao);
        }

        [HttpGet]
        public ActionResult<TransacaoDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet("list")]
        public ActionResult<List<TransacaoDto>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPut]
        public IActionResult Update(TransacaoDto usuario)
        {
            _service.Update(transacao);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
