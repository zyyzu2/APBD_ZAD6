namespace APBD_ZAD6.Repositories;

public interface IMedicamentRepository
{
    public Task<bool> CheckMedicamentExists(int id);
}