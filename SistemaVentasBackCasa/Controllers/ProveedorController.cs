using Microsoft.AspNetCore.Mvc;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorService _proveedorService;

        public object JwtConfigurator { get; private set; }

        public ProveedorController(IProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [Route("ListarProveedores")]
        [HttpGet]
        public async Task<IActionResult> ListarProveedor()
        {
            try
            {
                var listProveedores = await _proveedorService.ListarProveedor();
                return Ok(listProveedores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("{idProveedor}")]
        [HttpGet]
        public async Task<IActionResult> ListarProveedorPorId(int idProveedor)
        {
            try
            {
                var proveedor = await _proveedorService.ListarProveedorPorId(idProveedor);
                return Ok(proveedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Agregar")]
        [HttpPost]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post([FromBody] Proveedor proveedor)
        {
            try
            {
                await _proveedorService.AgregarProveedor(proveedor);
                return Ok(new { message = "Se agrego el proveedor exitosamente", ok = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{idProveedor}")]
        public async Task<IActionResult> EditarProveedor(int idProveedor, [FromBody] Proveedor proveedor)
        {
            try
            {
                if (idProveedor != proveedor.Id)
                {
                    return BadRequest();
                }

                await _proveedorService.EditarProveedor(proveedor);
                return Ok(new { message = "Se editó el proveedor exitosamente", ok = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("{idProveedor}")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<IActionResult> Delete(int idProveedor)
        {
            try
            {
                await _proveedorService.EliminarProveedor(idProveedor);
                return Ok(new { message = "El proveedor fue eliminado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
