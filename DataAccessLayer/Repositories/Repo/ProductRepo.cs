using DataAccessLayer.DTO.ProductDTO;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Data;

namespace DataAccessLayer.Repositories.Repo
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
           
            product.Feedbacks ??= new List<Feedback>();

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public bool DeleteProduct(int ProductId)
        {
            var product = _context.Products.Include(f => f.Feedbacks).FirstOrDefault(x => x.Id == ProductId);
            var check = _context.Feedbacks.FirstOrDefault(x=> x.ProductId  == ProductId);

            if (product != null && check == null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {

            var Products = await _context.Products.ToListAsync();
            return Products;
        }
    }
}
