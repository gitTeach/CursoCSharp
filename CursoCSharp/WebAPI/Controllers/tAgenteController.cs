using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using Entity.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unity;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class tAgenteController : BaseApiController
    {

        #region Campos

        [Dependency]
        public IAgenteRepository _agenteRepository { get; set; }
        //public AgenteRepository _agenteRepository {get; set;}

        //public tAgenteController()
        //{
        //    _agenteRepository = new AgenteRepository();
        //}

        public tAgenteController(IAgenteRepository agenteRepository)
        {
            this._agenteRepository = agenteRepository;
        }

        #endregion

        #region Acciones
        [HttpGet]
        [ActionName("getAll")]
        public IActionResult getAll()
        {
            try
            {
                if (ValidateToken()) 
                { 
                var data = _agenteRepository.GetAll();
                return Ok(data);
                }
                else
                {
                    return this.StatusCode(StatusCodes.Status401Unauthorized, "Token no valido");
                }
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
                throw;
            }
        }

        [HttpPost]
        [ActionName("save")]
        public IActionResult Save([FromBody] Agente agente)
        {
            try
            {
                var exist = _agenteRepository.Exist(agente.Nombre);
                if (exist) return BadRequest("Agente ya existe");

                var data = _agenteRepository.Save(agente);
                if (data) return Created("", data);
                else return Ok(data);

            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet]
        [ActionName("getById")]
        public IActionResult getById([FromQuery] int id) {

            try
            {
                var data = _agenteRepository.GetbyId(id);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return BadRequest("No se encontró un agente para el id proporcionado");
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet]
        [ActionName("listarAlumnos")]
        public IActionResult listarAlumnos()
        {
            try
            {   
                return Ok(ListadoAlumnos);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
                throw;
            }
        }

        [HttpGet]
        [ActionName("agregarAlumnos")]
        public IActionResult agregarAlumnos([FromQuery] string nombre)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                    return BadRequest("Nombre no valido");
                else
                {
                    agregarAlumno(nombre);
                    return Ok("alumno agregado");
                }
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