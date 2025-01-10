using FSD_Project.Data;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore;

namespace FSD_Project.Services
{
    public interface IReservationService
    {
        Task<bool> CreateReservationAsync(Reservation reservation);
        Task<List<Reservation>> GetReservationsAsync();
        Task<bool> IsTableAvailableAsync(int tableId, DateTime reservationTime);
    }

    public class ReservationService : IReservationService
    {
        private readonly IDbContextFactory<FSD_ProjectContext> _contextFactory;

        public ReservationService(IDbContextFactory<FSD_ProjectContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<bool> CreateReservationAsync(Reservation reservation)
        {
            try
            {
                using var context = await _contextFactory.CreateDbContextAsync();

                // Check if table is available
                if (!await IsTableAvailableAsync(reservation.TableID, reservation.ReservedDateTime))
                {
                    return false;
                }

                // Set audit fields
                reservation.DateCreated = DateTime.Now;
                reservation.DateUpdated = DateTime.Now;
                reservation.CreatedBy = "System"; // You might want to get this from the logged-in user
                reservation.UpdatedBy = "System";

                context.Reservation.Add(reservation);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Reservation>> GetReservationsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Reservation
                .OrderByDescending(r => r.ReservedDateTime)
                .ToListAsync();
        }

        public async Task<bool> IsTableAvailableAsync(int tableId, DateTime reservationTime)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            // Check if there are any overlapping reservations
            // Assuming a 2-hour dining duration
            var endTime = reservationTime.AddHours(2);

            return !await context.Reservation.AnyAsync(r =>
                r.TableID == tableId &&
                r.ReservedDateTime < endTime &&
                r.ReservedDateTime.AddHours(2) > reservationTime);
        }
    }
}