using APBD_ZAD6.DTOs;
using APBD_ZAD6.Models;
using APBD_ZAD6.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_ZAD6.Controllers;

[Route("/api/prescriptions")]
[ApiController]
public class PrescriptionController : ControllerBase
{
    private readonly IPrescriptionService _prescriptionService;

    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddPrescription(PrescriptionDTO prescriptionDto)
    {
        try
        {
            await _prescriptionService.AddNewPrescription(prescriptionDto);
        }
        catch (BadHttpRequestException e)
        {
            return BadRequest(e.Message);
        }
        
        return Ok();
    }
    
}