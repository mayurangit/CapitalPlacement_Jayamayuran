using CapitalPlacement_Jayamayuran.DTOs;
using CapitalPlacement_Jayamayuran.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacement_Jayamayuran.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class QuestionController : ControllerBase
    {
        private readonly InterfaceQuestion _interfaceQuestion;
        public QuestionController(InterfaceQuestion interfaceQuestion)
        {
            _interfaceQuestion = interfaceQuestion;
        }



        [HttpPost]
        [Route("Save Question")]
        public IActionResult Save (DTOQuetion dTOQuetion)
        {
            var x = _interfaceQuestion.Add(dTOQuetion);
            if(x==true)
            {
                return Ok("Success");
            }
            return BadRequest("Failed To Add");
        }





        [HttpPut]
        [Route("Update Question")]

        public IActionResult Edit(Guid id, DTOQuetion dTOQuetion) {
            var question = _interfaceQuestion.update(id, dTOQuetion);
            if (question==null)
            {
                return BadRequest("Failed to update");
            }
            else
                return Ok(question);    

        }
    }
}
