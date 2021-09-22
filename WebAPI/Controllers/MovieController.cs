using BusinessLogicLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
        /// <summary>
        /// Renvoi un film avec son casting
        /// </summary>
        /// <param name="Id">Obligatoirement un entier</param>
        /// <response code="200">Requête validée</response>
        /// <returns>Renvoi un film avec son casting
        /// </returns>
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(_service.GetById(Id));
        }

        /// <summary>
        /// Supprime un film
        /// </summary>
        /// <param name="Id"></param>
        /// <response code="400">Vous essayez de supprimer un favoris</response>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _service.Delete(Id);
                return Ok();
            }
            catch(InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
