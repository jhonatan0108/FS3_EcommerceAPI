﻿using Ecommerce.Comunes.Clases.Contratos.Clientes;
using Ecommerce.Dominio.Services.Clientes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesService _clientesService;

        public ClientesController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<ClienteContract> lista = _clientesService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            ClienteContract cliente = _clientesService.Get(id);
            
            if(cliente != null) return Ok(cliente);
            
            return BadRequest();
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Insert([FromBody] ClienteContract contract)
        {
            return Ok(_clientesService.Insert(contract));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] ClienteContract contract)
        {
            return Ok(_clientesService.Update(contract));
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_clientesService.Delete(id));
        }
    }
}
