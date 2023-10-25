using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _imageService;
    

        public CarImagesController(ICarImageService imageService)
        {
            _imageService = imageService;
        }




        [HttpPost("add")]
        public IActionResult AddAsync([FromForm(Name = ("image"))] IFormFile file, [FromForm] CarImage carImage)
        //FromForm ile modele ve entities e bağlanıyoruz
        //IFormFile>>HttpRequest ile gönderilen dosyayı temsil eder.

        {
            var result = _imageService.Add(file, carImage);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _imageService.Delete(carImage);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _imageService.Update(file, carImage);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _imageService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _imageService.GetByCarId(carId);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _imageService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
