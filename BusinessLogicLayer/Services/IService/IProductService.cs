using DataAccessLayer.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.IService
{
    public interface IProductService
    {
        Task<IEnumerable<RespondProductDTO>> getAll();
        Task AddProduct(RequestProductDTO productDTO);
        bool DeleteProduct(int productId);
    }
}
