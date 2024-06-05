using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;

namespace APBD_ZAD6.Repositories;

public interface IPatientRepository
{
    public Task<Patient?> AddNewPatient(PatientDTO patientDto);
    public Task<bool> CheckPatientExists(int id);
    public Task<Patient?> GetPatientById(int id);
}