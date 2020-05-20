using System;
using System.Collections.Generic;
using AutoMapper;
using backend.Api.Models;
using backend.Api.Profiles;
using backend.Domain.Entities;
using backend.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;

            var coniguration = new MapperConfiguration(cfg=> {
                cfg.AddProfile<OrganizationProfile>();
            });

            _mapper = coniguration.CreateMapper();

        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IEnumerable<PersonModel>>(_personService.GetAll()));
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
        [HttpDelete("{id}")]
        public IActionResult DeteleById(Guid id)
        {
            _personService.Delete(id);
            return Ok();
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        [HttpPut()]
        public IActionResult Put([FromBody] PersonModel personModel)
        {
            var coniguration = new MapperConfiguration(cfg=> {
                cfg.CreateMap<PersonModel, Person>();
            });
            var person = _mapper.Map<Person>(personModel);
            return Ok(_mapper.Map<PersonModel>(_personService.Update(person)));
        }
        
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [HttpPost()]
        public IActionResult Post([FromBody] PersonCreateModel personModel)
        {
            
            var person = _mapper.Map<Person>(personModel);
            return Ok(_mapper.Map<PersonModel>(_personService.Add(person)));
        }
    }
}
