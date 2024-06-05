namespace APBD_ZAD6.Services;

public interface IMedicamentService
{
    public Task<bool> CheckMedicamentExists(int id);
}