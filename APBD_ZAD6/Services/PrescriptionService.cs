using APBD_ZAD6.DTOs;
using APBD_ZAD6.Exceptions;
using APBD_ZAD6.Repositories;

namespace APBD_ZAD6.Services;

public class PrescriptionService : IPrescriptionService
{
    private readonly IPrescriptionRepository _repository;
    private readonly IPatientService _patientService;
    private readonly IMedicamentService _medicamentService;

    public PrescriptionService(IPrescriptionRepository repository)
    {
        _repository = repository;
    }
    public async Task<bool> AddNewPrescription(PrescriptionDTO prescriptionDto)
    {
        if (prescriptionDto.Date > prescriptionDto.DueDate) throw new BadHttpRequestException("DueDate should be before Date");
        if (!await _patientService.CheckPatientExists(prescriptionDto.PatientDto.IdPatient))
        {
            await _patientService.AddNewPatient(prescriptionDto.PatientDto);
        }

        foreach (var med in prescriptionDto.MedicamentDtos)
        {
            if (!await _medicamentService.CheckMedicamentExists(med.IdMedicament))
                throw new NotFoundException("Med with id " + med.IdMedicament + " not found");
        }
        if (prescriptionDto.MedicamentDtos.Count > 10) throw new BadHttpRequestException("Recepta moze obejmowac maksymalnie 10 lekow");
        await _repository.AddNewPrescription(prescriptionDto);
        return true;
    }
}