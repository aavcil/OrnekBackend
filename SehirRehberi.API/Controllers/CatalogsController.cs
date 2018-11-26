using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dtos;
using AutoMapper;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Catalogs")]
    public class CatalogsController : Controller
    {
         private IAppRepository _appRepository;
        private IMapper _mapper;
        public CatalogsController(AppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetCatalogs()
        {
            var catalog = _appRepository.GetCatalogs();
            var catalogForReturns = _mapper.Map<List<CatalogForReturnDto>>(catalog);
            return Ok(catalogForReturns);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Catalog catalog)
        {
            _appRepository.Add(catalog);
            _appRepository.SaveAll();
            return Ok(catalog);

        }
    }
}