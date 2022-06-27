using GarageVoxTeneo.BLL.DTO;
using GarageVoxTeneo.BLL.Services;
using GarageVoxTeneo.Models;
using GarageVoxTeneo.Models.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace GarageVoxTeneo.Controllers
{
    public class GaragesController : Controller
    {
        private GaragesService garagesService;
        private CarsService carsService;

        public GaragesController(GaragesService garagesService, CarsService carsService)
        {
            this.garagesService = garagesService;
            this.carsService = carsService;
        }

        public IActionResult Index()
        {
            IEnumerable<Garages> garages = garagesService.GetAll()
                                                       .Select(b => b.ToModel())
                                                       .OrderBy(b => b.Name);
            
            return View(garages);
        }
        public IActionResult Details(int id)
        {

            Garages garage = garagesService.GetById(id)
                .ToModel();

            IEnumerable<Cars> cars = carsService.GetByGarage(id).Select(b => b.ToModel());

            GarageDetail detailsModel = new GarageDetail()
            {
                IdGarage = garage.IdGarage,
                Name = garage.Name,
                Cars = cars
            };
            return View(detailsModel);
        }
    }
}
