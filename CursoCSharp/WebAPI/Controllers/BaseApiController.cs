using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

        public static List<string> ListadoAlumnos = new List<string>();

        public Guid TokenServer = new Guid("4c814c94-dc96-439a-93fc-a07ae1e10a4d");
        public bool ValidateToken()
        {
            var req = Request.Headers[HeaderNames.Authorization];
            var sreq = req.ToString();
            sreq = sreq.Replace("Bearer ", "");
            var tokenRequest = new Guid(sreq);

            if (tokenRequest == TokenServer)
                return true;
            else
                return false;
        }

        public BaseApiController() {

            //ListadoAlumnos.Add("Cesar");
            //ListadoAlumnos.Add("Keny");
            //ListadoAlumnos.Add("Jose");
            //ListadoAlumnos.Add("Maverick");
            //ListadoAlumnos.Add("Victoria");
            //ListadoAlumnos.Add("Douglas");
        }

        public void agregarAlumno(string nombre)
        {
            ListadoAlumnos.Add(nombre);
        }


    }
}