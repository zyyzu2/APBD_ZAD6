using System.Runtime.InteropServices.JavaScript;

namespace APBD_ZAD6.DTOs;

public class PrescriptionDTO
{
    public PatientDTO PatientDto { get; set; }
    public List<MedicamentDTO> MedicamentDtos { get; set; }
    public DoctorDTO DoctorDto { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}