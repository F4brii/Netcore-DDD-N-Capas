using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test.Application.Models;
using test.Application.UseCases;

namespace test.API.Controllers {

    [ApiController]
    [Route ("[controller]")]
    public class EstudianteController : ControllerBase {

        [HttpGet]
        public IActionResult Add () {
            var estudianteUseCase = new EstudianteUseCase ();

            var estudianteID = estudianteUseCase.Get (1);

            return new JsonResult (estudianteID);
        }
    }
}