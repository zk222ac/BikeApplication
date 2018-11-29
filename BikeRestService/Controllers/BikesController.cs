using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeLibrary.handler;
using BikeLibrary.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private readonly BikesHandler handler = BikesHandler.Instance;

        // GET: api/Bikes
        [HttpGet]
        [Route("")]
        public IEnumerable<Bike> Get()
        {
            return handler.GetAll();
        }

        // GET: api/Bikes/5
        [HttpGet]
        [Route("{id}")]
        public Bike Get(int id)
        {
            return handler.GetFromId(id);
        }

        // GET: api/Bikes/5
        [HttpGet]
        [Route("biketype/{biketype}")]
        public List<Bike> GetByType(string biketype)
        {
            return handler.GetByType(biketype);
        }

        // POST: api/Bikes/5
        [HttpPost]
        [Route("{id}")]
        public bool BuyABike(int id, [FromBody] Customer customer)
        {
            return handler.BuyBike(id, customer);
        }

        // GET: api/Bikes/bought
        [HttpGet]
        [Route("bought")]
        public IEnumerable<ABuy> Getbought()
        {
            return BikesHandler.BoughtBikes;
        }
    }
}
