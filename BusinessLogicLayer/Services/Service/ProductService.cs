using AutoMapper;
using BusinessLogicLayer.Services.IService;
using DataAccessLayer.DTO.ProductDTO;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Service
{
    #region
    //public class ProductService : IProductService
    //{
    //    private readonly IProductRepo _repo;
    //    private IMapper _mapper;

    //    public ProductService(IProductRepo repo, IMapper mapper)
    //    {
    //        _repo = repo;
    //        _mapper = mapper;
    //    }

    //    public Task AddProduct(RequestProductDTO productDTO)
    //    {
    //        var product = _mapper.Map<Product>(productDTO);
    //        return _repo.AddProductAsync(product);
    //    }

    //    public bool DeleteProduct(int productId)
    //    {
    //        bool  product = _repo.DeleteProduct(productId);
    //        return product;
    //    }

    //    public async Task<IEnumerable<RespondProductDTO>> getAll()
    //    {
    //        var Products = await _repo.GetAllProductsAsync();
    //       return _mapper.Map<IEnumerable<RespondProductDTO>>(Products);
    //    }
    //}
    #endregion
}
