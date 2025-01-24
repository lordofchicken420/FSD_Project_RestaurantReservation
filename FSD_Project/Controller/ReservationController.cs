//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using FSD_Project.Domain;
//using FSD_Project.Data;

//namespace FSD_Project.Controllers
//{
//    public class ReservationController : Controller
//    {
//        private readonly FSD_ProjectContext _context;

//        public ReservationController(FSD_ProjectContext context)
//        {
//            _context = context;
//        }

//        public async Task<IActionResult> Details(int id)
//        {
//            // Fetch the reservation and its associated ratings
//            var reservation = await _context.Reservation // Corrected to match DbSet name
//                .Include(r => r.Ratings)
//                .FirstOrDefaultAsync(r => r.Id == id); // Use `Id` as the primary key

//            if (reservation == null)
//            {
//                return NotFound();
//            }

//            // Return the view with the reservation and ratings data
//            return View(reservation);
//        }
//    }
//}
