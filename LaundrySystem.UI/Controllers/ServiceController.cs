using AutoMapper;
using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepo _serviceRepo;
        //private readonly IMapper _mapper;

        public ServiceController(IServiceRepo serviceRepo) //, 
            //IMapper mapper)
        {
            _serviceRepo = serviceRepo;
            //_mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Service/GetServices")]
        public async Task<IEnumerable<tblService>> GetServices()
        {
            var obj = await _serviceRepo.GetAllServicesAsync();
            //var objT = _mapper.Map<IEnumerable<tblService>>(obj);

            //if (objT == null) return (IEnumerable<tblService>)NotFound();

            return (IEnumerable<tblService>)Ok(obj);
        }

        //[HttpGet("GetAllCountries", Name = "GetAllCountries")]
        //public async Task<IActionResult> GetAllCountries()
        //{
        //    var objFromRepo = await _countryRepo.GetAllCountriesAsync();

        //    var obj = _mapper.Map<IEnumerable<tblCountry>>(objFromRepo);

        //    if (obj == null) return NotFound();

        //    return Ok(obj);
        //}

        //[HttpDelete("DeleteCountry/{CountryID}", Name = "DeleteCountry")]
        //public async Task<IActionResult> DeleteCountry(int CountryID)
        //{
        //    var objFromRepo = _countryRepo.GetCountry(CountryID);
        //    if (objFromRepo == null)
        //    {
        //        return NotFound();
        //    }

        //    await _countryRepo.DeleteCountryAsync(objFromRepo);

        //    if (_countryRepo.Save() == false)
        //    {
        //        throw new Exception($"Deleting Country {CountryID} failed on save.");
        //    }

        //    return NoContent();
        //}



        //[HttpPost("PostCountry", Name = "PostCountry")]
        //public async Task<IActionResult> PostCountry([FromBody] CountryForInsertModel model)
        //{
        //    if (model == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return new UnprocessableEntityObjectResult(ModelState);
        //    }

        //    await _countryRepo.AddCountryAsync(model.CountryName, model.Nationality, model.CountryCode);

        //    return Ok(model);
        //}

        //[HttpPut("PutCountry", Name = "PutCountry")]
        //public async Task<IActionResult> PutCountry([FromBody] CountryForUpdateModel model)
        //{
        //    if (model == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return new UnprocessableEntityObjectResult(ModelState);
        //    }

        //    await _countryRepo.UpdateCountryAsync(model.CountryID, model.CountryName, model.Nationality, model.CountryCode);

        //    return Ok(model);
        //}

    }
}
