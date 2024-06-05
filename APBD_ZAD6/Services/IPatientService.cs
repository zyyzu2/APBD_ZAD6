using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;

namespace APBD_ZAD6.Services;

public interface IPatientService
{
    public Task<bool> CheckPatientExists(int id);
    public Task<Patient?> AddNewPatient(PatientDTO patientDto);
}