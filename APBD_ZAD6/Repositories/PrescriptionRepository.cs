using APBD_ZAD6.Context;
using APBD_ZAD6.DTOs;
using APBD_ZAD6.Exceptions;
using APBD_ZAD6.Models;
using APBD_ZAD6.Services;

namespace APBD_ZAD6.Repositories;

public class PrescriptionRepository : IPrescriptionRepository
{
    private readonly AppDbContext _dbContext;
    private readonly IDoctorService _doctorService;

    public PrescriptionRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Prescription> AddNewPrescription(PrescriptionDTO prescriptionDto)
    {
        var d = await _doctorService.GetDoctorById(prescriptionDto.DoctorDto.IdDoctor);
        if (d is null) throw new NotFoundException("Provided doctor not found");
        var p = new Prescription()
        {
            Date = prescriptionDto.Date,
            DueDate = prescriptionDto.DueDate,
            IdDoctor = prescriptionDto.DoctorDto.IdDoctor,
            IdPatient = prescriptionDto.PatientDto.IdPatient
            
        } 
    }
}