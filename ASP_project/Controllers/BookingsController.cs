using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_project.Data;
using ASP_project.Models;

namespace ASP_project.Controllers
{
    public class BookingsController : Controller
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Bookings.Include(b => b.Customer).Include(b => b.Employee).Include(b => b.Offer).Include(b => b.Payment).Include(b => b.Room);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .Include(b => b.Offer)
                .Include(b => b.Payment)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.Booking_Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["Customer_Id"] = new SelectList(_context.Customers, "Customer_Id", "Customer_Name");
            ViewData["Employee_Id"] = new SelectList(_context.Employees, "Employee_Id", "Employee_Name");
            ViewData["Offer_Id"] = new SelectList(_context.Offer, "Offer_Id", "Offer_Name");
            ViewData["Payment_Id"] = new SelectList(_context.Payments, "Payment_Id", "Payment_Amount");
            ViewData["Room_Id"] = new SelectList(_context.Rooms, "Room_ID", "Room_Number");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Booking_Id,Room_Id,Employee_Id,Customer_Id,Booking_Date,CheckIn_Date,CheckOut_Date,Payment_Id,Offer_Id,Booking_Note")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customer_Id"] = new SelectList(_context.Customers, "Customer_Id", "Customer_Email", booking.Customer_Id);
            ViewData["Employee_Id"] = new SelectList(_context.Employees, "Employee_Id", "Employee_Email", booking.Employee_Id);
            ViewData["Offer_Id"] = new SelectList(_context.Offer, "Offer_Id", "Offer_Description", booking.Offer_Id);
            ViewData["Payment_Id"] = new SelectList(_context.Payments, "Payment_Id", "Payment_Amount", booking.Payment_Id);
            ViewData["Room_Id"] = new SelectList(_context.Rooms, "Room_ID", "Room_Size", booking.Room_Id);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["Customer_Id"] = new SelectList(_context.Customers, "Customer_Id", "Customer_Email", booking.Customer_Id);
            ViewData["Employee_Id"] = new SelectList(_context.Employees, "Employee_Id", "Employee_Email", booking.Employee_Id);
            ViewData["Offer_Id"] = new SelectList(_context.Offer, "Offer_Id", "Offer_Description", booking.Offer_Id);
            ViewData["Payment_Id"] = new SelectList(_context.Payments, "Payment_Id", "Payment_Amount", booking.Payment_Id);
            ViewData["Room_Id"] = new SelectList(_context.Rooms, "Room_ID", "Room_Size", booking.Room_Id);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Booking_Id,Room_Id,Employee_Id,Customer_Id,Booking_Date,CheckIn_Date,CheckOut_Date,Payment_Id,Offer_Id,Booking_Note")] Booking booking)
        {
            if (id != booking.Booking_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Booking_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customer_Id"] = new SelectList(_context.Customers, "Customer_Id", "Customer_Email", booking.Customer_Id);
            ViewData["Employee_Id"] = new SelectList(_context.Employees, "Employee_Id", "Employee_Email", booking.Employee_Id);
            ViewData["Offer_Id"] = new SelectList(_context.Offer, "Offer_Id", "Offer_Description", booking.Offer_Id);
            ViewData["Payment_Id"] = new SelectList(_context.Payments, "Payment_Id", "Payment_Amount", booking.Payment_Id);
            ViewData["Room_Id"] = new SelectList(_context.Rooms, "Room_ID", "Room_Size", booking.Room_Id);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .Include(b => b.Offer)
                .Include(b => b.Payment)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.Booking_Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bookings == null)
            {
                return Problem("Entity set 'AppDbContext.Bookings'  is null.");
            }
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
          return (_context.Bookings?.Any(e => e.Booking_Id == id)).GetValueOrDefault();
        }
    }
}
