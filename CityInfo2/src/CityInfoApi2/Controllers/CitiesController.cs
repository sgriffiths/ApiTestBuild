using CityInfoApi2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi2.Controllers
{
    public class CitiesController : Controller
    {
        [Route("api/cities")]
        //[HttpGet("api/cities")]
        public JsonResult GetCities()
        {

            return new JsonResult(CitiesDataStore.Current.Cities);
        }    
    }
}
