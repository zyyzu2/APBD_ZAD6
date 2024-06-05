using APBD_ZAD6.Models;

namespace APBD_ZAD6.Services;

public interface IDoctorService
{
    public Task<Doctor?> GetDoctorById(int id);
}