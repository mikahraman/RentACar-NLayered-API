using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {

        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET: api/brands
        [HttpGet]
        public IActionResult GetAll()
        {

            var brands = _brandService.GetAll();


            return Ok(brands);
        }


        [HttpPost]
        public IActionResult Add(Brand brand)
        {

            _brandService.Add(brand);


            return Created("api/brands/" + brand.Id, brand); 
        }
    }
}