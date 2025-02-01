using FSD_Project.Data;
using Microsoft.EntityFrameworkCore;

namespace FSD_Project.Services
{
    public class TableService
    {
        private readonly IDbContextFactory<FSD_ProjectContext> _dbFactory;

        public TableService(IDbContextFactory<FSD_ProjectContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<(int TotalTables, int AvailableTables, double AvailabilityPercentage)> GetTableAvailabilityAsync()
        {
            using var context = _dbFactory.CreateDbContext();

            int totalTables = await context.Table.CountAsync();
            int availableTables = await context.Table.CountAsync(t => t.Status);
            double percentage = totalTables > 0 ? (availableTables / (double)totalTables) * 100 : 0;

            return (totalTables, availableTables, percentage);
        }
    }
}



