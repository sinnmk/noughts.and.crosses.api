﻿using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Client.Services;

namespace Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private PersonService PersonService { get; }

        public PersonController(PersonService personService)
        {
            PersonService = personService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(PersonService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(PersonModel model)
        {
            if (model == null)
                return BadRequest($"{nameof(model)} is null.");
            var result = PersonService.Add(model);
            return Json(result);
        }

        [HttpPatch]
        public IActionResult Update(PersonModel model)
        {
            if (model == null)
                return BadRequest($"{nameof(model)} is null.");
            var result = PersonService.Update(model);
            return Json(result);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest($"{nameof(id)} <= 0.");
            var result = PersonService.Delete(id);
            return Json(result);
        }
    }
}
