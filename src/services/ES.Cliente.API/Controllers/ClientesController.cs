using ES.Clientes.API.Application.Commands;
using ES.Core.Mediator.Interfaces;
using ES.WebAPI.Core.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ES.Clientes.API.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : MainController
    {

        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Pedro Horita", "pedro.horita@gmail.com", "38279373888"));

            return CustomResponse(resultado);
        }
    }
}
