using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerMvcAngularJs.Services;

namespace BeerMvcAngularJs.Controllers
{
    public class BeerController : Controller
    {
        private readonly BeerService _beerService;

        public BeerController(BeerService beerService)
        {
            _beerService = beerService;
        }

        public IActionResult Index()
        {
            return View(_beerService.Beers);
        }

        public IActionResult IndexViewModel()
        {
            return Json(_beerService.Beers);
        }

        [Route("Beer/Edit/{id:int?}")]
        public IActionResult Edit(int? id)
        {
            return id is not null 
                ? View(_beerService.Beers[id.Value]) 
                : Index();
        }

        [Route("Beer/Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            _beerService.RemoveBeer(id);
            return RedirectToAction("Index");
        }
    }
}
