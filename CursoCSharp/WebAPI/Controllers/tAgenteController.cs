using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class tAgenteController : ControllerBase
    {

        #region Campos

        public AgenteRepository _agenteRepository {get; set;}

        public tAgenteController()
        {
            _agenteRepository = new AgenteRepository();
        }

        #endregion

        #region Acciones
        [HttpGet]
        [ActionName("getAll")]
        public IActionResult getAll()
        {
            try
            {
                var data = _agenteRepository.GetAll();
                return Ok(data);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
                throw;
            }
        }

        #endregion


    }
}