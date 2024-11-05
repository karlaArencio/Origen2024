using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Origen2024.BD.DATA;
using Origen2024.BD.DATA.Entity;
using Origen2024.Shared.DTO;

namespace Origen2024.Server.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosControllers : ControllerBase
    {
        private readonly Context context;

        public UsuariosControllers(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearUsuarioDTO entidadDTO)
        {
            try
            {
                Usuario entidad = new Usuario();
                entidad.NombreUsuario = entidadDTO.NombreUsuario;
                entidad.Contraseña = entidadDTO.Contraseña;
                entidad.Mail = entidadDTO.Mail;

                context.Usuarios.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }
        //[HttpPut("{id: int}")] //api/Usuarios/2
        //public async Task<ActionResult> Put(int id, [FromBody] Usuario entidad)
        //{
        //    if (id != entidad.Id)
        //    {
        //        return BadRequest("Datos Incorrectos");
        //    }
        ////    var pepe = await context.Usuarios
        ////        .Where(e => e.Id == id)
        ////        .FirstOrDefaultAsync();
        ////    if((pepe == null))
        ////    {
        ////        return NotFound("No existe la clase de documento buscado.");
        ////    }
        ////    pepe.NombreUsuario = entidad.NombreUsuario;
        ////    pepe.Contraseña = entidad.Contraseña;
        ////    pepe.Mail = entidad.Mail;
        ////    pepe.Activo = entidad.Activo;

        ////    try
        ////    {
        ////        context.Usuarios.Update(pepe);

        ////        await context.SaveChangesAsync();
        ////        return Ok();
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        return BadRequest(e.InnerException.Message);
        ////    }
        ////}
        //[HttpDelete("{id:int}")] //api/Usuario/2

        //public async Task<ActionResult> Delete(int id)
        //{
        //    var existe = await context.Usuarios.AnyAsync(x => x.Id == id);
        //    if (!existe)
        //    {
        //        return NotFound($"La clase de documento{id} no existe.");
        //    }
        //    Usuario EntidadABorrar = new Usuario();
        //    EntidadABorrar.Id = id;

        //    context.Remove(EntidadABorrar);
        //    await context.SaveChangesAsync();
        //    return Ok();
        //}

    }

}
