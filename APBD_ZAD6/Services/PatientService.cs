using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;
using APBD_ZAD6.Repositories;

namespace APBD_ZAD6.Services;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;

    public PatientService(IPatientRepository _repository)
    {
        _patientRepository = _repository;
    }
    public async Task<bool> CheckPatientExists(int id)
    {
        return await _patientRepository.CheckPatientExists(id);
    }

    public async Task<Patient?> AddNewPatient(PatientDTO patientDto)
    {
        return await _patientRepository.AddNewPatient(patientDto);
    }
}