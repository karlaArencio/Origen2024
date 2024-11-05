using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Origen2024.BD.DATA;
using Origen2024.BD.DATA.Entity;
using Origen2024.Shared.DTO;

namespace Origen2024.Server.Controllers
{
    [ApiController]
    [Route("api/Registros")]
    public class RegistrosControllers : ControllerBase
    {
        private readonly Context context;

        public RegistrosControllers(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Registro>>> Get()
        {
            return await context.Registros.ToListAsync();
        }

        //[HttpGet("{id:int")]//api/Registros/
        //public async Task<ActionResult<Registro>> Get(int id)
        //{
        //    var pepe = await context.Registros
        //        .FirstOrDefaultAsync(x => x.Id == id);
        //    if (pepe == null)
        //    {
        //        return NotFound();
        //    }
        //    return pepe;
        //}
        [HttpGet("{cod}")]//api/Registros/DNI
        public async Task<ActionResult<Registro>> GetByCod(string cod)
        {
            var pepe = await context.Registros
                .FirstOrDefaultAsync(x => x.Codigo == cod);
            if (pepe == null)
            {
                return NotFound();
            }
            return pepe;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearRegistroDTO entidadDTO)
        {
            try
           {
                Registro entidad = new Registro();
                entidad.Codigo = entidadDTO.Codigo;
                entidad.Fecha = entidadDTO.Fecha;
                entidad.Estado = entidadDTO.Estado;

               

                context.Registros.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
           catch (Exception e)
            {
               return BadRequest(e.InnerException.Message);
            }
        }
        //[HttpPut("{id: int}")] //api/Registros/2
        //public async Task<ActionResult> Put(int id, [FromBody] Registro entidad)
        //{
         //   if (id != entidad.Id)
        //    {
        //        return BadRequest("Datos Incorrectos");
        //    }
        //    var pepe = await context.Registros
        //        .Where(e => e.Id == id)
        //        .FirstOrDefaultAsync();

        //    if ((pepe == null))
        //    {
        //        return NotFound("No existe la clase de documento buscado.");

        //    }
        //    pepe.Codigo = entidad.Codigo;
        //    pepe.Fecha = entidad.Fecha;
        //    pepe.Estado = entidad.Estado;
        //    pepe.Activo = entidad.Activo;

        //    try
        //    {
        //        context.Registros.Update(pepe);

        //        await context.SaveChangesAsync();
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}






        //[HttpDelete("{id : int}")]//api/Registros/2
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var existe = await context.Registros.AnyAsync(x => x.Id == id);
        //    if (!existe)
        //    {
        //        return NotFound($"La clase de documento{id} no existe.");
        //    }
        //    Registro EntidadABorrar = new Registro();
        //    EntidadABorrar.Id = id;

        //    context.Remove(EntidadABorrar);
        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
    }
}
