using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public object JwtConfigurator { get; private set; }

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [Route("ListarCategorias")]
        [HttpGet]
        public async Task<IActionResult> ListarCategoria()
        {
            try
            {
                var listCategorias = await _categoriaService.ListarCategoria();
                return Ok(listCategorias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("{idCategoria}")]
        [HttpGet]
        public async Task<IActionResult> ListarCategoriaPorId(int idCategoria)
        {
            try
            {
                var categoria = await _categoriaService.ListarCategoriaPorId(idCategoria);
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Agregar")]
        [HttpPost]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post([FromBody]Categoria categoria)
        {
            try
            {
                await _categoriaService.AgregarCategoria(categoria); 
                return Ok(new { message = "Se agrego la categoría exitosamente", ok = true });
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{idCategoria}")]
        public async Task<IActionResult> EditarCategoria(int idCategoria, [FromBody] Categoria categoria)
        {
            try
            {
                if (idCategoria != categoria.Id)
                {
                    return BadRequest();
                }

                await _categoriaService.EditarCategoria(categoria);
                return Ok(new { message = "Se editó la categoría exitosamente", ok = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("{idCategoria}")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<IActionResult> Delete(int idCategoria)
        {
            try
            {
                await _categoriaService.EliminarCategoria(idCategoria);
                return Ok(new { message = "La categoria fue eliminada con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
