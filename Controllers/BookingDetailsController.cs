using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FleetManagement.Model;

namespace FleetManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailsController : ControllerBase
    {
        private readonly FleetContext _context;

        public BookingDetailsController(FleetContext context)
        {
            _context = context;
        }

        // GET: api/BookingDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingDetail>>> GetBookingDetail()
        {
          if (_context.BookingDetail == null)
          {
              return NotFound();
          }
            return await _context.BookingDetail.ToListAsync();
        }

        // GET: api/BookingDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDetail>> GetBookingDetail(int? id)
        {
          if (_context.BookingDetail == null)
          {
              return NotFound();
          }
            var bookingDetail = await _context.BookingDetail.FindAsync(id);

            if (bookingDetail == null)
            {
                return NotFound();
            }

            return bookingDetail;
        }

        // PUT: api/BookingDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingDetail(int? id, BookingDetail bookingDetail)
        {
            if (id != bookingDetail.BookingDetailId)
            {
                return BadRequest();
            }

            _context.Entry(bookingDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingDetailExists(id))
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

        // POST: api/BookingDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingDetail>> PostBookingDetail(BookingDetail bookingDetail)
        {
          if (_context.BookingDetail == null)
          {
              return Problem("Entity set 'FleetContext.BookingDetail'  is null.");
          }
            _context.BookingDetail.Add(bookingDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookingDetail", new { id = bookingDetail.BookingDetailId }, bookingDetail);
        }

        // DELETE: api/BookingDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingDetail(int? id)
        {
            if (_context.BookingDetail == null)
            {
                return NotFound();
            }
            var bookingDetail = await _context.BookingDetail.FindAsync(id);
            if (bookingDetail == null)
            {
                return NotFound();
            }

            _context.BookingDetail.Remove(bookingDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingDetailExists(int? id)
        {
            return (_context.BookingDetail?.Any(e => e.BookingDetailId == id)).GetValueOrDefault();
        }
    }
}
