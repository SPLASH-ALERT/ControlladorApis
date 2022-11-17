using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using api_Proyecto.Models;


using Microsoft.AspNetCore.Cors;

namespace api_Proyecto.Controllers
{

    [EnableCors("Reglas")]
    [Route("api/[controller]")]
    [ApiController]
    public class MBDatos : ControllerBase
    {

        public readonly splash_dataContext _dbcontext;

        public MBDatos(splash_dataContext _context)
        {
            _dbcontext = _context;
        }


        // apis para administrar usuarios   

//----------------------------------------rEGISTRO DE DATOS DE ASISTENTE

        [HttpGet]
        [Route("ListaAsistente")]
        public ActionResult ListaAsistente(int idUAsistente) //----> listar usuarios asistentes
        {
            Usuario id = _dbcontext.Usuarios.Find(idUAsistente);
            idUAsistente = 2;


            try
            {

                id = _dbcontext.Usuarios.Where(p=>p.IdUsuario == idUAsistente).FirstOrDefault();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = id });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = id });
            }
        }

        [HttpPost]
        [Route("GuardarAsistente")]
        public ActionResult GuardarAsistente([FromBody] Usuario objeto) //----> listar usuarios  asistente
        {
            List<Usuario> Lista = new List<Usuario>();

            try
            {
                int idRol = 2;

                objeto.IdRol = idRol;




                _dbcontext.Usuarios.Add(objeto);
                _dbcontext.SaveChanges();   
                
                
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        //-----------------------------------------------------REGISTRO DE DATOS DE ADMINISTRADOR

        [HttpGet]
        [Route("ListaAdmin")]
        public ActionResult Listaadmin(int idUAsistente) //----> listar usuarios administrador
        {
            Usuario id = _dbcontext.Usuarios.Find(idUAsistente);
            idUAsistente = 1;


            try
            {

                id = _dbcontext.Usuarios.Where(p => p.IdUsuario == idUAsistente).FirstOrDefault();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = id });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = id });
            }
        }


        [HttpPost]
        [Route("GuardarAdmin")]
        public ActionResult GuardarAdmin([FromBody] Usuario objeto) //----> listar usuarios 
        {
            List<Usuario> Lista = new List<Usuario>();

            try
            {
                int idRol = 1;

                objeto.IdRol = idRol;




                _dbcontext.Usuarios.Add(objeto);
                _dbcontext.SaveChanges();


                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }


        //---------------------------------------REGISTRO DE CAUSAS

        [HttpPost]
        [Route("GuardarCausaNino")]
        public ActionResult GuardarCausaNino([FromBody] Causa objeto) //----> listar usuarios
        {
            List<Causa> Lista = new List<Causa>();

            try
            {
                string causaN = "niño";
                DateTime fecha = DateTime.Now;
                int idUsuario = 2;

                objeto.Causa1 = causaN;
                objeto.FechaCausa = fecha;
                objeto.IdUsuario = idUsuario;

                _dbcontext.Causas.Add(objeto);
                _dbcontext.SaveChanges();


                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        

        [HttpPost]
        [Route("GuardarCausaAdulto")]
        public ActionResult GuardarCausaAdulto([FromBody] Causa objeto) //----> listar usuarios
        {
            List<Causa> Lista = new List<Causa>();

            try
            {
                string causaN = "adulto";
                DateTime fecha = DateTime.Now;
                int idUsuario = 2;

                objeto.Causa1 = causaN;
                objeto.FechaCausa = fecha;
                objeto.IdUsuario = idUsuario;

                _dbcontext.Causas.Add(objeto);
                _dbcontext.SaveChanges();


                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }


        [HttpPost]
        [Route("GuardarCausaAnimal")]
        public ActionResult GuardarCausaAnimal([FromBody] Causa objeto) //----> listar usuarios
        {
            List<Causa> Lista = new List<Causa>();

            try
            {
                string causaN = "animal";
                DateTime fecha = DateTime.Now;
                int idUsuario = 2;

                objeto.Causa1 = causaN;
                objeto.FechaCausa = fecha;
                objeto.IdUsuario = idUsuario;

                _dbcontext.Causas.Add(objeto);
                _dbcontext.SaveChanges();


                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPost]
        [Route("GuardarCausaObjeto")]
        public ActionResult GuardarCausaObjeto([FromBody] Causa objeto) //----> listar usuarios
        {
            List<Causa> Lista = new List<Causa>();

            try
            {
                string causaN = "Objeto";
                DateTime fecha = DateTime.Now;
                int idUsuario = 2;

                objeto.Causa1 = causaN;
                objeto.FechaCausa = fecha;
                objeto.IdUsuario = idUsuario;

                _dbcontext.Causas.Add(objeto);
                _dbcontext.SaveChanges();


                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }




    }
}
