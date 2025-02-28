﻿using FSD_Project.Data;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore;

namespace FSD_Project.Services
{
    public interface IReservationService
    {
        Task<bool> CreateReservationAsync(Reservation reservation, string reservationBranch);
        Task<List<Reservation>> GetReservationsAsync();
        Task<bool> IsTableAvailableAsync(int tableId, DateTime reservationTime);
        Task<bool> CancelReservationAsync(int reservationId);

        Task<List<Reservation>> GetReservationsByCustomerIdAsync(string customerId);
    }

    public class ReservationService : IReservationService
    {
        private readonly IDbContextFactory<FSD_ProjectContext> _contextFactory;

        public ReservationService(IDbContextFactory<FSD_ProjectContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<bool> CreateReservationAsync(Reservation reservation, string reservationBranch)
        {
            try
            {
                using var context = await _contextFactory.CreateDbContextAsync();


                // Determine the table range based on the selected branch
                int startTableId = 0;
                int endTableId = 0;

                if (reservationBranch == "1") // Branch 1
                {
                    startTableId = 1;
                    endTableId = 5;
                }
                else if (reservationBranch == "2") // Branch 2
                {
                    startTableId = 6;
                    endTableId = 10;
                }
                else
                {
                    // Invalid branch value, handle error or return false
                    Console.WriteLine("Invalid branch selected");
                    return false;
                }




                // ✅ Find the lowest available table ID
                var availableTable = await context.Table
            .Where(t => t.Status == true && t.Id >= startTableId && t.Id <= endTableId) // Only available tables in the specified range
            .OrderBy(t => t.Id) // Get the lowest table ID
            .FirstOrDefaultAsync();

                if (availableTable == null)
                {
                    return false; // No tables available
                }

                // Assign the lowest available table to the reservation
                reservation.TableID = availableTable.Id;

                // ✅ Mark the table as unavailable
                availableTable.Status = false;

                // Save the reservation and update table status
                context.Reservation.Add(reservation);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating reservation: {ex.Message}");
                return false;
            }
        }



        public async Task<List<Reservation>> GetReservationsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Reservation
                .Include(r => r.Table) // Ensure Table details are loaded
                .OrderByDescending(r => r.ReservedDateTime)
                .ToListAsync();
        }
        public async Task<List<Reservation>> GetReservationsByCustomerIdAsync(string customerId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Reservation
                .Include(r => r.Table) // Include related table details if needed
                .Where(r => r.CustomerId == customerId) // Filter by customer
                .OrderByDescending(r => r.ReservedDateTime)
                .ToListAsync();
        }

        public async Task<bool> IsTableAvailableAsync(int tableId, DateTime reservationTime)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            // Check if the table exists and is available
            var table = await context.Table.FindAsync(tableId);
            if (table == null || !table.Status)  // 🚨 Ensure the table is marked as available
            {
                return false;
            }

            // Assuming a 2-hour dining duration
            var endTime = reservationTime.AddHours(2);

            return !await context.Reservation.AnyAsync(r =>
                r.TableID == tableId &&
                r.ReservedDateTime < endTime &&
                r.ReservedDateTime.AddHours(2) > reservationTime);
        }

        public async Task<bool> CancelReservationAsync(int reservationId)
        {
            try
            {
                using var context = await _contextFactory.CreateDbContextAsync();

                // Find the reservation
                var reservation = await context.Reservation.FirstOrDefaultAsync(r => r.Id == reservationId);
                if (reservation == null)
                {
                    return false; // Reservation not found
                }

                // Find the associated table
                var table = await context.Table.FirstOrDefaultAsync(t => t.Id == reservation.TableID);
                if (table != null)
                {
                    // ✅ Mark table as available
                    table.Status = true;
                    
                    // ✅ Attach the table and mark it as modified
                    context.Attach(table);
                    context.Entry(table).Property(t => t.Status).IsModified = true;
                }

                // Remove the reservation
                context.Reservation.Remove(reservation);

                // Save changes
                await context.SaveChangesAsync();

                return true; // Successfully canceled
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error canceling reservation: {ex.Message}");
                return false;
            }
        }

    }
}