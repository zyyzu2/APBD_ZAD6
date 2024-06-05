using System.Runtime.InteropServices.JavaScript;
using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;

namespace APBD_ZAD6.Repositories;

public interface IPrescriptionRepository
{
    public Task<Prescription> AddNewPrescription(PrescriptionDTO prescriptionDto);
}