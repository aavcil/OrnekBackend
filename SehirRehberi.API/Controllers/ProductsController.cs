using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dtos;
using SehirRehberi.API.Models;


namespace SehirRehberi.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]

    public class ProductsController : Controller
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public ProductsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetProducts()
        {
            var products = _appRepository.GetProducts();
            var productsToReturn = _mapper.Map<List<CityForListDto>>(products);
            return Ok(productsToReturn);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Product product)
        {
            _appRepository.Add(product);
            _appRepository.SaveAll();
            return Ok(product);

        }

        [HttpGet]
        [Route("detail")]
        public ActionResult GetProductById(int id)
        {
            var city = _appRepository.GetProductById(id);
            var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            return Ok(cityToReturn);
        }

        [HttpGet]
        [Route("Photos")]
        public ActionResult GetPhotosByProduct(int cityId)
        {
            var photos = _appRepository.GetPhotosByCity(cityId);
            return Ok(photos);
        }
        [HttpGet]
        [Route("Catalogs")]

        public ActionResult GetCatalogs()
        {
            var catalog = _appRepository.GetCatalogs();
            var catalogForReturns = _mapper.Map<List<CatalogForReturnDto>>(catalog);
            return Ok(catalogForReturns);
        }

    }
}