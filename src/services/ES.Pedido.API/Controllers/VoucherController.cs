﻿using ES.Pedidos.API.Application.DTO;
using ES.Pedidos.API.Application.Queries.Interfaces;
using ES.WebAPI.Core.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace ES.Pedidos.API.Controllers
{
    [Authorize]
    public class VoucherController : MainController
    {
        private readonly IVoucherQueries _voucherQueries;

        public VoucherController(IVoucherQueries voucherQueries)
        {
            _voucherQueries = voucherQueries;
        }

        [HttpGet("voucher/{codigo}")]
        [ProducesResponseType(typeof(VoucherDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ObterPorCodigo(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) 
                return NotFound();

            var voucher = await _voucherQueries.ObterVoucherPorCodigo(codigo);

           return voucher == null ? NotFound() : CustomResponse(voucher);
        }
    }
}
