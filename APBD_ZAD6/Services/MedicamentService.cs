using APBD_ZAD6.Repositories;

namespace APBD_ZAD6.Services;

public class MedicamentService : IMedicamentService
{
    private readonly IMedicamentRepository _medicamentRepository;

    public MedicamentService(IMedicamentRepository medicamentRepository)
    {
        _medicamentRepository = medicamentRepository;
    }
    
    public async Task<bool> CheckMedicamentExists(int id)
    {
        return await _medicamentRepository.CheckMedicamentExists(id);
    }
}