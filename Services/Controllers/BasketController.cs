using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace Services.Controllers
{
    public class BasketController : ApiController
    {
        private readonly IRepository _repo;

        public BasketController(IRepository repo) => _repo = repo;

        // GET api/<controller>
        [EnableQuery]
        public IEnumerable<Basket> Get()
        {
            return _repo.getAllBaskets();
        }

        // GET api/<controller>/5
        public Basket Get(string id)
        {
            return _repo.getBasketById(id);
        }

    }
}