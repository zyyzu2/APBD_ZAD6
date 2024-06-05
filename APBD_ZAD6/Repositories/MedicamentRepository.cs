using APBD_ZAD6.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace APBD_ZAD6.Repositories;

public class MedicamentRepository : IMedicamentRepository
{

    private readonly AppDbContext _dbContext;

    public MedicamentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> CheckMedicamentExists(int id)
    {
        return await _dbContext.Medicaments.FirstOrDefaultAsync(s => s.IdMedicament == id) is not null;
    }
}