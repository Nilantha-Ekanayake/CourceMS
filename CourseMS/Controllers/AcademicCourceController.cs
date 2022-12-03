using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cource.Application;
using Cource.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseMS.Controllers
{
    [Route("api/[controller]")]
    public class AcademicCourceController : Controller
    {
        private readonly IAcademicCourceService academicCourceService;

        public AcademicCourceController(IAcademicCourceService academicCourceService)
        {
            this.academicCourceService = academicCourceService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<AcademicCource>> Get()
        {
            return Ok(academicCourceService.GetCources());
        }

        [HttpGet]
        [Route("id")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AcademicCource))]
        public ActionResult<List<AcademicCource>> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id invalid");
            }
             
            else
            {
                var cource = academicCourceService.GetCourcesById(id);
                if(cource==null)
                {
                    return NotFound("Cource not found");
                }
                else
                return Ok(academicCourceService.GetCourcesById(id));
            }
          
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AcademicCource))]
        public async Task<IActionResult> Post([FromBody] AcademicCource academicCource)
        {
            if (academicCource.Title.Length == 0)
            {
                return BadRequest("Academic cource");
            }
            else
            {
                var responce = await academicCourceService.create(academicCource);
                return CreatedAtAction(nameof(GetById),new {id = responce.Id}, responce);
            }
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AcademicCource))]
        public async Task<IActionResult> Update([FromBody] AcademicCource academicCource)
        {
            if (academicCource.Id != 0)
            {
                return BadRequest("Academic Id empty");
            }
            else
            {
                return Created("", await academicCourceService.Update(academicCource));
            }
        }


    }
}

