using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{
    public class Product
    {
        public Product()
        {
            Photos=new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string measure { get; set; }
        public bool interior { get; set; }
        public int categoryId { get; set; }

        public List<Photo> Photos { get; set; }
        public User User { get; set; }

    }
}
