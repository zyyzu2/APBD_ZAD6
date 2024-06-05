using APBD_ZAD6.Context;
using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_ZAD6.Repositories;

public class PatientRepository : IPatientRepository
{

    private readonly AppDbContext _dbContext;

    public PatientRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Patient?> AddNewPatient(PatientDTO patientDto)
    {
        Patient? p = new Patient()
        {
            FirstName = patientDto.FirstName,
            LastName = patientDto.LastName,
            Birthdate = patientDto.Birthdate
        };
        await _dbContext.Patients.AddAsync(p);
        await _dbContext.SaveChangesAsync();
        return p;
    }

    public async Task<bool> CheckPatientExists(int id)
    {
        return await _dbContext.Patients.FirstOrDefaultAsync(p => p.IdPatient == id) is not null;
    }

    public async Task<Patient?> GetPatientById(int id)
    {
        return await _dbContext.Patients.FirstOrDefaultAsync(p => p.IdPatient == id);
    }
}