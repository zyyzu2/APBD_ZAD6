using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;

namespace APBD_ZAD6.Services;

public interface IPrescriptionService
{

    public Task<bool> AddNewPrescription(PrescriptionDTO prescriptionDto);
}