using Microsoft.AspNetCore.Mvc;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [Route("ListarClientes")]
        [HttpGet]
        public async Task<IActionResult> ListarCliente()
        {
            try
            {
                var listClientes = await _clienteService.ListarCliente();
                return Ok(listClientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("{idCliente}")]
        [HttpGet]
        public async Task<IActionResult> ListarClientePorId(int idCliente)
        {
            try
            {
                var cliente = await _clienteService.ListarClientePorId(idCliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Agregar")]
        [HttpPost]
        public async Task<IActionResult> AgregarCliente([FromBody]Cliente cliente)
        {
            try
            {
                await _clienteService.AgregarCliente(cliente);
                return Ok(new { message = "Cliente agregado exitosamente", ok = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("{idCliente}")]
        [HttpPut]
        public async Task<IActionResult> EditarCliente(int idCliente, [FromBody]Cliente cliente)
        {
            try
            {
                if (idCliente != cliente.Id)
                {
                    return BadRequest();
                }

                await _clienteService.EditarCliente(cliente);
                return Ok(new { message = "Cliente editado exitosamente", ok = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("{idCliente}")]
        [HttpDelete]
        public async Task<IActionResult> EliminarCliente(int idCliente)
        {
            try
            {
                await _clienteService.EliminarCliente(idCliente);
                return Ok(new { message ="Cliente eliminado exitosamente", ok = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
