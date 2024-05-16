using CapitalPlacement_Jayamayuran.DTOs;
using CapitalPlacement_Jayamayuran.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace CapitalPlacement_Jayamayuran.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly InterfaceProgram _interfaceProgram;
        public ProgramController(InterfaceProgram interfaceProgram)
        {
            _interfaceProgram = interfaceProgram;
        }
        [HttpGet]
        [Route("GetProgram")]

        public IActionResult Get()
        {
            return Ok(_interfaceProgram.GetAll());
        }

        [HttpPost]
        [Route("Save Program")]
        public IActionResult Save(DTOProgram dTOProgram) { 
        
           var result = _interfaceProgram.Add(dTOProgram);
            if(result)
            {
                return Ok("Success");
            }
            return BadRequest("Unable to Add");
        }
    }
}
