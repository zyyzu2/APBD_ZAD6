using APBD_ZAD6.Models;

namespace APBD_ZAD6.Repositories;

public interface IDoctorRepository
{
    public Task<Doctor?> GetDoctorById(int id);
}