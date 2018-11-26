using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Dtos
{
    public class CatalogForReturnDto
    {
        public int id { get; set; }
        public string catalogUrl { get; set; }
        public string description { get; set; }
    }
}
