using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIS_GOL.Application;
using System;
using System.Threading.Tasks;

namespace SIS_GOL.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneApplication _airplane;
        public AirplaneController(IAirplaneApplication airplane)
        {
            _airplane = airplane;
        }

        [HttpGet]
        public async Task<IActionResult> GetAirPlane()
        {
            try
            {
                return Ok(await _airplane.FindAll());
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco!");
            }
        }

    
        [HttpPost("Create")]
        public async Task<IActionResult> Create(AirplaneViewModel entity)
        {
            try
            {
                await _airplane.Create(entity);
              
                 return Created($"/api/Airplane/",entity);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco!");
            }
            
        }
        [HttpGet("Alter/{id}")]
        public async Task<IActionResult> Alter(long id)
        {
            try
            {
                return Ok( await _airplane.FindOne(id));
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco!");
            }
        }

        [HttpPut("Alter")]
        public async Task<IActionResult> Alter(AirplaneViewModel entity)
        {
            try
            {
                await _airplane.Update(entity);
                return Created($"/api/Alter/{entity.IdAviao}",entity);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco!");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                await _airplane.Delete(id);
               return Created($"/api/Airplane/",id);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco!");
            }
        }
    }
}