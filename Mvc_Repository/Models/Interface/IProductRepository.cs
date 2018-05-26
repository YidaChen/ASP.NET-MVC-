using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Repository.Models.Interface
{
    interface IProductRepository : IDisposable
    {
        void Create(Products instance);

        void Update(Products instance);

        void Delete(Products instance);

        Products Get(int productID);

        IQueryable<Products> GetAll();

        void SaveChanges();
    }
}
