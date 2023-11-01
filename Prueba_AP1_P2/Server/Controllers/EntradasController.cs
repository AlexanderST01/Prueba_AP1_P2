﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_AP1_P2.Server.DAL;
using Prueba_AP1_P2.Shared.Models;

namespace Prueba_AP1_P2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        private readonly Context _context;

        public EntradasController(Context context)
        {
            _context = context;
        }

        // GET: api/Entradas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entradas>>> GetEntradas()
        {
          if (_context.Entradas == null)
          {
              return NotFound();
          }
            return await _context.Entradas.ToListAsync();
        }

        // GET: api/Entradas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entradas>> GetEntradas(int id)
        {
          if (_context.Entradas == null)
          {
              return NotFound();
          }
            var entradas = await _context.Entradas
                .Include(e => e.EntredasDetalles)
                .Where(e => e.EntradaId == id)
                .FirstOrDefaultAsync();

            if (entradas == null)
            {
                return NotFound();
            }

            return entradas;
        }

        // PUT: api/Entradas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntradas(int id, Entradas entradas)
        {
            if (id != entradas.EntradaId)
            {
                return BadRequest();
            }

            _context.Entry(entradas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntradasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Entradas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entradas>> PostEntradas(Entradas entradas)
        {
            if (!EntradasExists(entradas.EntradaId))
                _context.Entradas.Add(entradas);
            else
                _context.Entradas.Update(entradas);

            await _context.SaveChangesAsync();

           // var entradaAnterior = _context.Entradas.Include(e => e.EntredasDetalles).AsNoTracking()
           //.FirstOrDefault(e => e.EntradaId == entradas.EntradaId);

           // if (entradaAnterior != null && entradaAnterior.EntredasDetalles != null)
           // {
           //     foreach (var productoConsumido in entradaAnterior.EntredasDetalles)
           //     {
           //         if (productoConsumido != null)
           //         {
           //             var producto = _context.Productos.Find(productoConsumido.ProductoId);

           //             if (producto != null)
           //             {
           //                 producto.Existencia -= productoConsumido.CantidadUtilizada;
           //                 _context.Productos.Update(producto);
           //                 await _context.SaveChangesAsync();
           //                 _context.Entry(producto).State = EntityState.Detached;
           //             }
           //         }
           //     }
           // }

            return Ok(entradas);
        }
                                        
        // DELETE: api/Entradas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntradas(int id)
        {
            if (_context.Entradas == null)
            {
                return NotFound();
            }
            var entradas = await _context.Entradas.FindAsync(id);
            if (entradas == null)
            {
                return NotFound();
            }

            _context.Entradas.Remove(entradas);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("DeleteDetalles/{id}")]
        public async Task<IActionResult> DeleteDetalles(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var entradas = await _context.EntredasDetalles.FirstOrDefaultAsync(td => td.DetalleId == id);
            if (entradas is null)
            {
                return NotFound();
            }

            _context.EntredasDetalles.Remove(entradas);
            await _context.SaveChangesAsync();

            return Ok();
        }


        private bool EntradasExists(int id)
        {
            return (_context.Entradas?.Any(e => e.EntradaId == id)).GetValueOrDefault();
        }
    }
}
