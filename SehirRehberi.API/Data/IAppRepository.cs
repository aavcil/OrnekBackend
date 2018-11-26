using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T:class ;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        List<Product> GetProducts();
        List<Photo> GetPhotosByCity(int productId);
        Product GetProductById(int productId);
        Photo GetPhoto(int id);
        List<Catalog> GetCatalogs();
       
    }
}
